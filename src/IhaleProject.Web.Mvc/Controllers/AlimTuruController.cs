using Abp.AspNetCore.Mvc.Authorization;
using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Authorization;
using IhaleProject.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IhaleProject.Web.Controllers
{
	//[AbpMvcAuthorize(PermissionNames.Pages_Users)]
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
	}
}
