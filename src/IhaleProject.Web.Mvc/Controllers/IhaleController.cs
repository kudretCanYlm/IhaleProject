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
using IhaleProject.Email;
using IhaleProject.Application.Contracts.Email;
using Abp.AspNetCore.Mvc.Authorization;
using IhaleProject.Authorization;

namespace IhaleProject.Web.Controllers
{
	[AbpMvcAuthorize(PermissionNames.Pages_Ihale)]
	public class IhaleController: IhaleProjectControllerBase
	{
		private readonly IIhaleAppService ihaleAppService;
		private readonly IBirimAppService birimAppService;
		private readonly IAlimUsuluAppService alimUsuluAppService;
		private readonly IAlimTuruAppService alimTuruAppService;
		private readonly IEmailAppService emailAppService;

		private readonly CreateIhaleDtoValidator createIhaleValidator=new CreateIhaleDtoValidator();
		private readonly UpdateIhaleDtoValidator updateIhaleValidator= new UpdateIhaleDtoValidator();

		public IhaleController(IIhaleAppService ihaleAppService, IBirimAppService birimAppService, IAlimUsuluAppService alimUsuluAppService, IAlimTuruAppService alimTuruAppService, IEmailAppService emailAppService)
		{
			this.ihaleAppService = ihaleAppService;
			this.birimAppService = birimAppService;
			this.alimUsuluAppService = alimUsuluAppService;
			this.alimTuruAppService = alimTuruAppService;
			this.emailAppService = emailAppService;
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
				//await emailAppService.SendIhaleMailToAllUser(createIhaleDto.IhaleAdi);
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
			var ihale = await ihaleAppService.GetUpdateModelAsync(id);

			int a = 200;

			return Json(ihale);
		}

		[HttpGet]
		public async Task<FileContentResult> GetIhaleFile(Guid id)
		{
			var ihaleFile = await ihaleAppService.GetFile(id);

			return new FileContentResult(ihaleFile.Bytes, ihaleFile.DosyaUzantisi)
			{
				FileDownloadName = ihaleFile.DosyaAdi
			};

		}
	}

}
