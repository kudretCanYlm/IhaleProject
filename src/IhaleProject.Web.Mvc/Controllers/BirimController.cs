using Abp.AspNetCore.Mvc.Authorization;
using Abp.Web.Models;
using FluentValidation.Results;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Authorization;
using IhaleProject.Controllers;
using IhaleProject.Web.Models.Birim;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace IhaleProject.Web.Controllers
{
	[AbpMvcAuthorize(PermissionNames.Pages_Birim)]
	public class BirimController : IhaleProjectControllerBase
	{
		private readonly IBirimAppService birimAppService;
		//will access with ICreateBirimDtoValidator interface
		private readonly CreateBirimDtoValidator createBirimValidator = new CreateBirimDtoValidator();
		private readonly UpdateBirimDtoValidator updateBirimValidator = new UpdateBirimDtoValidator();

		public BirimController(IBirimAppService birimAppService)
		{
			this.birimAppService = birimAppService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<JsonResult> GetBirimler()
		{
			var birimler = await birimAppService.GetAllAsync();

			return Json(new BirimListViewModel()
			{
				Birims = birimler
			});
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<JsonResult> GetBirim(Guid id)
		{
			var birim = await birimAppService.GetAsync(id);

			return Json(birim);
		}

		[HttpPost]
		public async Task<JsonResult> Delete(Guid Id)
		{
			await birimAppService.DeleteAsync(Id);

			return Json(new { isSuccess = true });
		}

		[HttpPost]
		public async Task<IActionResult> Create(CreateBirimDto createBirimDto)
		{
			var result = createBirimValidator.Validate(createBirimDto);

			if (result.IsValid)
			{
				await birimAppService.CreateAsync(createBirimDto);
			}

			return RedirectToAction("Index");
		}

		[HttpPost]
		public async Task<IActionResult> Update([FromRoute] Guid id, UpdateBirimDto updateBirimDto)
		{

			var a = 4;

			var result = updateBirimValidator.Validate(updateBirimDto);

			if (result.IsValid)
			{
				await birimAppService.UpdateAsync(id, updateBirimDto);
				
			}

			return Ok();
		}
	}
}