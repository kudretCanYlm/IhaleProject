using Abp.Domain.Repositories;
using System;

namespace IhaleProject.Domain.Email
{
	public interface IEmailRepository:IRepository<EmailEntity,Guid>
	{
	}
}
