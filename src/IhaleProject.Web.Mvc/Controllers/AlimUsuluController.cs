using Abp.AspNetCore.Mvc.Authorization;
using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Authorization;
using IhaleProject.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IhaleProject.Web.Controllers
{
	//[AbpMvcAuthorize(PermissionNames.Pages_Users)]
	public class AlimUsuluController : IhaleProjectControllerBase
	{
		private readonly IAlimTuruAppService alimTuruAppService;

		public AlimUsuluController(IAlimTuruAppService alimTuruAppService)
		{
			this.alimTuruAppService = alimTuruAppService;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}
