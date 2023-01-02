using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Abp.Net.Mail;
using System.Net;
using System.Net.Mail;

namespace IhaleProject.Domain.EmailSender
{
	public class TaskManager:IDomainService
	{
			private readonly IEmailSender _emailSender;

			public TaskManager(IEmailSender emailSender)
			{
				_emailSender = emailSender;
			}
		void MailAt()
		{
			var fromAddress = new MailAddress("sender@example.com", "Sender");
			var toAddress = new MailAddress("receiver@example.com", "Receiver");
			const string subject = "My Mail Subject";
			const string body = "My Mail";
		}

		//public void Assign(Task task, Person person)
		//{
		//	//Assign task to the person
		//	task.AssignedTo = person;

		//	//Send a notification email
		//	_emailSender.Send(
		//		to: person.EmailAddress,
		//		subject: "You have a new task!",
		//		body: $"A new task is assigned for you: <b>{task.Title}</b>",
		//		isBodyHtml: true
		//	);
		//}
	}
}
