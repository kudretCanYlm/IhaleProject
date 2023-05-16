using Abp.Domain.Repositories;
using System;

namespace IhaleProject.Domain.Email
{
	public interface IEmailLogRepository:IRepository<EmailLogEntity,Guid>
	{
	}
}
