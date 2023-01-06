using Abp.AspNetCore.Mvc.Authorization;
using Abp.Authorization;
using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Authorization;
using IhaleProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IhaleProject.Web.Controllers
{
	[AbpMvcAuthorize(PermissionNames.Pages_Arsiv)]
	public class ArsivController : IhaleProjectControllerBase
	{
		private readonly IIhaleAppService ihaleAppService;

		public ArsivController(IIhaleAppService ihaleAppService)
		{
			this.ihaleAppService = ihaleAppService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<JsonResult> GetArsivler()
		{
			var arsiv = await ihaleAppService.GetArsivliIhaleler();

			return Json(new { arsivler = arsiv });
		}
	}
}
