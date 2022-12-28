using FluentValidation.Results;
using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Application.Contracts.AlimUsulu;
using IhaleProject.Application.Contracts.Birim;
using System.Threading.Tasks;
using System;
using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Controllers;
using IhaleProject.Web.Models.Ihale;
using Microsoft.AspNetCore.Mvc;

namespace IhaleProject.Web.Controllers
{
	public class IhaleController: IhaleProjectControllerBase
	{
		private readonly IIhaleAppService ihaleAppService;
		private readonly IBirimAppService birimAppService;
		private readonly IAlimUsuluAppService alimUsuluAppService;
		private readonly IAlimTuruAppService alimTuruAppService;

		private readonly CreateIhaleDtoValidator createIhaleValidator=new CreateIhaleDtoValidator();
		private readonly UpdateIhaleDtoValidator updateIhaleValidator= new UpdateIhaleDtoValidator();

		public IhaleController(IIhaleAppService ihaleAppService, IBirimAppService birimAppService, IAlimUsuluAppService alimUsuluAppService, IAlimTuruAppService alimTuruAppService)
		{
			this.ihaleAppService = ihaleAppService;
			this.birimAppService = birimAppService;
			this.alimUsuluAppService = alimUsuluAppService;
			this.alimTuruAppService = alimTuruAppService;
		}

		public IActionResult Index()
        {
            return View();
		}

		public async Task<IActionResult> Create(IhalePostModel ihalePostModel)
		{
			
			var createIhaleDto = ObjectMapper.Map<CreateIhaleDto>(ihalePostModel);

			try
			{
				createIhaleDto.Birim = await birimAppService.GetEntityAsync(ihalePostModel.BirimId);
				createIhaleDto.alimTuru = await alimTuruAppService.GetEntityAsync(ihalePostModel.AlimTuruId);
				createIhaleDto.alimUsulu = await alimUsuluAppService.GetEntityAsync(ihalePostModel.AlimUsuluId);
			}
			catch 
			{
				return View("Index");
			}

			
			//add vaidations
			var result = createIhaleValidator.Validate(createIhaleDto);

			if (result.IsValid)
			{
				await ihaleAppService.CreateAsync(createIhaleDto);
			}

			else
			{
				foreach (ValidationFailure failer in result.Errors)
				{

					ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);

				}

			}

			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<JsonResult> GetIhaleler()
		{
			var ihaleler = await ihaleAppService.GetAllAsync();

			return Json(new IhaleListViewModel()
			{
				ihaleler = ihaleler
			});
		}

		[HttpGet]
		public async Task<JsonResult> GetIhale(Guid id)
		{
			var birim = await ihaleAppService.GetAsync(id);

			return Json(birim);
		}
	}

}
