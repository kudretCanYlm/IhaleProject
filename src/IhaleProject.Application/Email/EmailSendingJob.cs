using Abp.BackgroundJobs;
using Abp.Dependency;
using Abp.Net.Mail;
using IhaleProject.Domain.Email;
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
		private readonly IEmailLogRepository emailLogRepository;

		public EmailSendingJob(IEmailSender emailSender)
		{
			_emailSender = emailSender;
		}

		public override async Task ExecuteAsync(EmailSendingArgs args)
		{
			try
			{
				await _emailSender.SendAsync(
						args.EmailAddress,
						args.Subject,
						args.Body
					);

				var emailLog = new EmailLogEntity();

				emailLog.EmailAddress = args.EmailAddress;
				emailLog.Subject = args.Subject;
				emailLog.Body = args.Body;


				await emailLogRepository.InsertAsync(emailLog);
			}
			catch (Exception)
			{


			}

		}
	}
}
