using IhaleProject.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace IhaleProject.Web.Controllers
{
	public class AnasayfaController : IhaleProjectControllerBase
	{
		public IActionResult Listele()
		{
			return View();
		}
	}
}
