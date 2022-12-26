using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Controllers;
using Microsoft.AspNetCore.Mvc;

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
	}
}
