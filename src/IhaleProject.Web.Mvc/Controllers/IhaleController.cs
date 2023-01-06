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
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace IhaleProject.Web.Controllers
{
	[AbpMvcAuthorize(PermissionNames.Pages_Ihale)]
	public class IhaleController : IhaleProjectControllerBase
	{
		private readonly IIhaleAppService ihaleAppService;
		private readonly IBirimAppService birimAppService;
		private readonly IAlimUsuluAppService alimUsuluAppService;
		private readonly IAlimTuruAppService alimTuruAppService;
		private readonly IEmailAppService emailAppService;

		private readonly CreateIhaleDtoValidator createIhaleValidator = new CreateIhaleDtoValidator();
		private readonly UpdateIhaleDtoValidator updateIhaleValidator = new UpdateIhaleDtoValidator();
		private readonly IhalePostModelValidator ihalePostModelValidator = new IhalePostModelValidator();
		private readonly IhalePostModelNoFileValidator ihalePostModelNoFileValidator = new IhalePostModelNoFileValidator();

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

			var result = ihalePostModelValidator.Validate(ihalePostModel);

			if (result.IsValid)
			{
				var createIhaleDto = ObjectMapper.Map<CreateIhaleDto>(ihalePostModel);

				try
				{
					createIhaleDto.Birim = await birimAppService.GetEntityAsync(ihalePostModel.BirimId);
					createIhaleDto.alimTuru = await alimTuruAppService.GetEntityAsync(ihalePostModel.AlimTuruId);
					createIhaleDto.alimUsulu = await alimUsuluAppService.GetEntityAsync(ihalePostModel.AlimUsuluId);

					await ihaleAppService.CreateAsync(createIhaleDto);
				}
				catch
				{
					return RedirectToAction("Index");
				}


				await emailAppService.SendIhaleMailToAllUser(createIhaleDto.IhaleAdi);

				return RedirectToAction("Index");
			}

			return RedirectToAction("Index");

		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<JsonResult> GetYayindakiIhaleler()
		{
			var ihaleler = await ihaleAppService.GetYayindakiIlanlar();

			return Json(new IhaleListViewModel()
			{
				ihaleler = ihaleler
			});
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<JsonResult> GetIhale(Guid id)
		{
			var ihale = await ihaleAppService.GetUpdateModelAsync(id);

			int a = 200;

			return Json(ihale);
		}

		[HttpGet]
		[AllowAnonymous]
		public async Task<FileContentResult> GetIhaleFile(Guid id)
		{
			var ihaleFile = await ihaleAppService.GetFile(id);

			return new FileContentResult(ihaleFile.Bytes, ihaleFile.DosyaUzantisi)
			{
				FileDownloadName = ihaleFile.DosyaAdi
			};

		}

		[HttpPost]
		public async Task<ActionResult> YayindanKaldir(Guid id)
		{
			try
			{
				await ihaleAppService.YayindanKaldir(id);
				return Ok();
			}
			catch (Exception)
			{

				return BadRequest();
			}
		}

		[HttpPost, AllowAnonymous]
		public async Task<ActionResult> Update([FromRoute] Guid id, IhalePostModelNoFile ihalePostModel)
		{
			var result = ihalePostModelNoFileValidator.Validate(ihalePostModel);

			if (result.IsValid)
			{
				var updateIhaleDto = ObjectMapper.Map<UpdateIhaleDto>(ihalePostModel);

				try
				{
					updateIhaleDto.Birim = await birimAppService.GetEntityAsync(ihalePostModel.BirimId);
					updateIhaleDto.alimTuru = await alimTuruAppService.GetEntityAsync(ihalePostModel.AlimTuruId);
					updateIhaleDto.alimUsulu = await alimUsuluAppService.GetEntityAsync(ihalePostModel.AlimUsuluId);

					await ihaleAppService.UpdateAsync(id, updateIhaleDto);

					return Ok();
				}
				catch
				{
					return BadRequest();
				}

			}

			return BadRequest();
		}

	}

}
