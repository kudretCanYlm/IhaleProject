using IhaleProject.Controllers;
using IhaleProject.Ihale;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using IhaleProject.Application.Contracts.Email;

namespace IhaleProject.Web.Controllers
{
	public class AnasayfaController : IhaleProjectControllerBase
	{

		private readonly IEmailAppService emailAppService;

		public AnasayfaController(IEmailAppService emailAppService)
		{
			this.emailAppService = emailAppService;
		}

		public IActionResult Listele()
		{
			return View();
		}

		[HttpPost]
		public async Task<ActionResult> MailEkle(CreateEmailDto mail)
		{
			try
			{
				bool status=await emailAppService.IsEmailAlreadyUsed(mail);

				if(status)
					return BadRequest();

				await emailAppService.Create(mail);

				return Ok();
				
			}
			catch (Exception)
			{

				return BadRequest();
			}
		}
	}
}
