using Abp.AspNetCore.Mvc.Authorization;
using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Authorization;
using IhaleProject.Controllers;
using IhaleProject.Ihale;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Drawing.Printing;
using System.Threading.Tasks;

namespace IhaleProject.Web.Controllers
{
	[AbpMvcAuthorize(PermissionNames.Pages_TumYayinlar)]
	public class TumYayinlarController : IhaleProjectControllerBase
	{
		private readonly IIhaleAppService ihaleAppService;

		public TumYayinlarController(IIhaleAppService ihaleAppService)
		{
			this.ihaleAppService = ihaleAppService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<JsonResult> GetTumYayinlar()
		{
			var ihaleler = await ihaleAppService.GetTumIhaleler();

			return Json(new { tumIhaleler = ihaleler });
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
