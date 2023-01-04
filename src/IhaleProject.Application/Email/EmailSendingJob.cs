using Abp.BackgroundJobs;
using Abp.Dependency;
using Abp.Net.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Email
{
	public class EmailSendingJob : AsyncBackgroundJob<EmailSendingArgs>, ITransientDependency
	{
		private readonly IEmailSender _emailSender;

		public EmailSendingJob(IEmailSender emailSender)
		{
			_emailSender = emailSender;
		}

		public override async Task ExecuteAsync(EmailSendingArgs args)
		{
			await _emailSender.SendAsync(
				args.EmailAddress,
				args.Subject,
				args.Body
			);
		}
	}
}
