using Abp.AspNetCore.Mvc.Authorization;
using FluentValidation;
using FluentValidation.Results;
using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Authorization;
using IhaleProject.Birim;
using IhaleProject.Controllers;
using IhaleProject.Web.Models.AlimTuru;
using IhaleProject.Web.Models.Birim;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IhaleProject.Web.Controllers
{
	[AbpMvcAuthorize(PermissionNames.Pages_AlimTuru)]
	public class AlimTuruController : IhaleProjectControllerBase
	{
		private readonly IAlimTuruAppService alimTuruAppService;
		private readonly CreateAlimTuruDTOValidator createAlimTuruValidator=new CreateAlimTuruDTOValidator();
		private readonly UpdateAlimTuruDTOValidator updateAlimTuruValidator=new UpdateAlimTuruDTOValidator();

		public AlimTuruController(IAlimTuruAppService alimTuruAppService)
		{
			this.alimTuruAppService = alimTuruAppService;
		}

		public async Task<IActionResult> Index()
		{
			return View();
		}

		[HttpGet]
		public async Task<JsonResult> GetAlimTurleri()
		{
			var AlimTurleri = await alimTuruAppService.GetAllAsync();

			return Json(new AlimTuruListViewModel()
			{
				alimTurleri = AlimTurleri
			});
		}

		[HttpGet]
		public async Task<JsonResult> GetAlimTuru(Guid id)
		{
			var AlimTuru = await alimTuruAppService.GetAsync(id);

			return Json(AlimTuru);
		}

		[HttpPost]
		public async Task<JsonResult> Delete(Guid Id)
		{
			await alimTuruAppService.DeleteAsync(Id);

			return Json(new { isSuccess = true });
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateAlimTuruDTO createAlimTuruDTO)
		{
			//add vaidations
			var result = createAlimTuruValidator.Validate(createAlimTuruDTO);

			if (result.IsValid)
			{
				await alimTuruAppService.CreateAsync(createAlimTuruDTO);
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

		[HttpPost]
		public async Task<JsonResult> Update([FromRoute] Guid id, UpdateAlimTuruDTO updateAlimTuruDTO)
		{

			//add vaidations
			var result = updateAlimTuruValidator.Validate(updateAlimTuruDTO);

			if (result.IsValid)
			{
				await alimTuruAppService.UpdateAsync(id, updateAlimTuruDTO);
			}

			else
			{
				foreach (ValidationFailure failer in result.Errors)
				{

					ModelState.AddModelError(failer.PropertyName, failer.ErrorMessage);

					return Json(new { ModelState });
				}

			}

			return Json(new { ModelState });

		}

	}
}
