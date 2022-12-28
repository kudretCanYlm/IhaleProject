using System.Threading.Tasks;
using System;
using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Birim;
using IhaleProject.Controllers;
using IhaleProject.Web.Models.Birim;
using Microsoft.AspNetCore.Mvc;
using IhaleProject.Migrations;
using IhaleProject.Web.Models.Ihale;

namespace IhaleProject.Web.Controllers
{
	public class IhaleController: IhaleProjectControllerBase
	{
		private readonly IIhaleAppService ihaleAppService;
		private readonly CreateIhaleDtoValidator createIhaleValidator=new CreateIhaleDtoValidator();
		private readonly UpdateIhaleDtoValidator updateIhaleValidator= new UpdateIhaleDtoValidator();

		public IhaleController(IIhaleAppService ihaleAppService)
		{
			this.ihaleAppService = ihaleAppService;
		}
		public IActionResult Index()
        {
            return View();
		}
        [HttpGet]
        public async Task<JsonResult> Getİhaleler()
        {
            var ihaleler = await ihaleAppService.GetAllAsync();

            return Json(new IhaleListViewModel()
            {
                ihaleler = ihaleler
            });
        }

        [HttpGet]
        public async Task<JsonResult> GetBirim(Guid id)
        {
            var birim = await ihaleAppService.GetAsync(id);

            return Json(birim);
        }
    }
}
