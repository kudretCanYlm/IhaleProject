using Abp.Dependency;
using Abp.Net.Mail;
using System.Threading.Tasks;

namespace IhaleProject.Email
{
	public class IhaleEmailService : ITransientDependency
	{
		private readonly IEmailSender _emailSender;

		public IhaleEmailService(IEmailSender emailSender)
		{
			_emailSender = emailSender;
		}

		public async Task SendMailAsync(string targetEmail)
		{
			await _emailSender.SendAsync(
				targetEmail,     // target email address
				"Yeni İhale Eklendi",         // subject
				"test mail"  // email body)
				);
		}
	}
}
