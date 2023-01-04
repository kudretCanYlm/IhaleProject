using IhaleProject.Application.Contracts.Email;
using IhaleProject.Controllers;
using IhaleProject.Web.Models.Email;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace IhaleProject.Web.Controllers
{
	public class EmailController : IhaleProjectControllerBase
	{
		private readonly IEmailAppService emailAppService;

		public EmailController(IEmailAppService emailAppService)
		{
			this.emailAppService = emailAppService;
		}
		
		public async Task<JsonResult> Post(CreateEmailDto createEmailDto)
		{
			

			if (await emailAppService.IsEmailAlreadyUsed(createEmailDto))
			{
				return Json(new EmailResponseModel
				{
					IsCreated = false
				});
			}

			await emailAppService.Create(createEmailDto);

			return Json(new EmailResponseModel
			{
				IsCreated = true
			});

		}
	}
}
