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
	[AbpMvcAuthorize(PermissionNames.Pages_SuresiBitmisYayinlar)]


	public class SuresiBitmisYayinlarController : IhaleProjectControllerBase
	{
		private readonly IIhaleAppService ihaleAppService;

		public SuresiBitmisYayinlarController(IIhaleAppService ihaleAppService)
		{
			this.ihaleAppService = ihaleAppService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<JsonResult> GetSuresiBitmisYayinlar()
		{
			var ihaleler = await ihaleAppService.GetIlanSuresiBitmisYayinlar();

			return Json(new { suresiBitmisYayinlar = ihaleler });
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
	}
}
