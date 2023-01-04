using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Application.Contracts.Email
{
	public interface IEmailAppService : IApplicationService
	{
		Task SendIhaleMailToAllUser(string ihaleAdi);
		Task<bool> IsEmailAlreadyUsed(CreateEmailDto email);
		Task Create(CreateEmailDto email);
	}
}
