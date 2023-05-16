using Abp.AspNetCore.Mvc.Authorization;
using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Authorization;
using IhaleProject.Controllers;
using IhaleProject.Ihale;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IhaleProject.Web.Controllers
{
	[AbpMvcAuthorize(PermissionNames.Pages_KaldirilmisYayinlar)]
	public class KaldirilmisYayinlarController : IhaleProjectControllerBase
	{
		private readonly IIhaleAppService ihaleAppService;

		public KaldirilmisYayinlarController(IIhaleAppService ihaleAppService)
		{
			this.ihaleAppService = ihaleAppService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<JsonResult> GetKaldirilmisYayinlar()
		{
			var ihaleler = await ihaleAppService.GetKaldirimisIhaleler();

			return Json(new { kaldirilmisIhaleler = ihaleler });
		}

		[HttpPost]
		public async Task<ActionResult> ArsiveEkle(Guid Id)
		{
			try
			{
				await ihaleAppService.ArsiveEkle(Id);
				return Ok();
			}
			catch (System.Exception ex)
			{

				return BadRequest(ex.Message);
			}

		}
		[HttpPost]
		public async Task<ActionResult> TekrarAktifEt(Guid Id)
		{
			try
			{
				await ihaleAppService.TekrarYayinla(Id);
				return Ok();
			}
			catch (System.Exception ex)
			{

				return BadRequest(ex.Message);
			}

		}
	}
}
