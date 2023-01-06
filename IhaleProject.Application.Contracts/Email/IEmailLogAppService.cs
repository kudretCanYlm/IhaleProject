using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Application.Contracts.Email
{
	internal interface IEmailLogAppService: IApplicationService
	{
		Task SaveLog(EmailSendingArgs args);
	}
}
