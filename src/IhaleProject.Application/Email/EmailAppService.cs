using Abp.BackgroundJobs;
using Abp.Net.Mail;
using IhaleProject.Application.Contracts.Email;
using IhaleProject.Domain.Email;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Email
{
	public class EmailAppService : IhaleProjectAppServiceBase, IEmailAppService
	{
		private readonly IBackgroundJobManager backgroundJobManager;
		private readonly IEmailRepository emailRepository;
		

		public EmailAppService(IBackgroundJobManager backgroundJobManager, IEmailRepository emailRepository)
		{
			this.backgroundJobManager = backgroundJobManager;
			this.emailRepository = emailRepository;
		}

		public async Task Create(CreateEmailDto email)
		{
			await emailRepository.InsertAsync(ObjectMapper.Map<EmailEntity>(email));
		}

		public async Task<bool> IsEmailAlreadyUsed(CreateEmailDto email)
		{
			bool isThere = await emailRepository.Query(x => x.AnyAsync(x => x.Email == email.Email));

			return isThere;
		}

		public async Task SendIhaleMailToAllUser(string ihaleAdi)
		{
			var users = await emailRepository.GetAllListAsync();

			foreach (var user in users)
			{
				await backgroundJobManager.EnqueueAsync<EmailSendingJob, EmailSendingArgs>(
					new EmailSendingArgs
					{
						EmailAddress=user.Email,
						Subject="Yeni İhale Bildirimi",
						Body=ihaleAdi+" ihalesi sisteme eklendi"
					}
					);
			}


		}
	}
}
