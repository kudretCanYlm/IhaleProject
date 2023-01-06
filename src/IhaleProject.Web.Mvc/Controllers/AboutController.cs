using IhaleProject.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IhaleProject.Web.Controllers
{
	public class AboutController : IhaleProjectControllerBase
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
