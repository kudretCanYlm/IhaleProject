using System.Threading.Tasks;
using System;
using Abp.AspNetCore.Mvc.Authorization;
using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Authorization;
using IhaleProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using IhaleProject.AlimUsulu;
using IhaleProject.Application.Contracts.AlimUsulu;
using IhaleProject.Web.Models.AlimUsulu;
using FluentValidation.Results;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Birim;
using IhaleProject.Web.Models.Birim;
using FluentValidation;

namespace IhaleProject.Web.Controllers
{
	public class AlimUsuluController : IhaleProjectControllerBase
	{
		private readonly IAlimUsuluAppService alimUsuluAppService;
		private readonly CreateAlimUsuluDTOValidator createAlimUsuluValidator = new CreateAlimUsuluDTOValidator();
		private readonly UpdateAlimUsuluDTOValidator updateAlimUsuluValidator = new UpdateAlimUsuluDTOValidator();

		public AlimUsuluController(IAlimUsuluAppService alimUsuluAppService)
		{
			this.alimUsuluAppService = alimUsuluAppService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public async Task<JsonResult> GetAlimUsullleri()
		{
			var AlimUsullleri = await alimUsuluAppService.GetAllAsync();

			return Json(new AlimUsuluListViewModel()
			{
				alimUsulleri = AlimUsullleri
			});
		}

		[HttpGet]
		public async Task<JsonResult> GetAlimUsul(Guid id)
		{
			var AlimUsul = await alimUsuluAppService.GetAsync(id);
			return Json(AlimUsul);
		}

		[HttpPost]
		public async Task<JsonResult> Delete(Guid Id)
		{
			await alimUsuluAppService.DeleteAsync(Id);

			return Json(new { isSuccess = true });
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateAlimUsuluDTO createAlimUsuluDTO)
		{
			//add vaidations
			var result = createAlimUsuluValidator.Validate(createAlimUsuluDTO);

			if (result.IsValid)
			{
				await alimUsuluAppService.CreateAsync(createAlimUsuluDTO);
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
		public async Task<JsonResult> Update([FromRoute] Guid id, UpdateAlimUsuluDTO updateAlimUsuluDTO)
		{

			//add vaidations
			var result = updateAlimUsuluValidator.Validate(updateAlimUsuluDTO);

			if (result.IsValid)
			{
				await alimUsuluAppService.UpdateAsync(id, updateAlimUsuluDTO);
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
