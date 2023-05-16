using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using IhaleProject.Domain.Email;
using IhaleProject.EntityFrameworkCore;
using System;

namespace IhaleProject.Email
{
	public class EfCoreEmailRepository: EfCoreRepositoryBase<IhaleProjectDbContext, EmailEntity, Guid>, IEmailRepository
	{
		public EfCoreEmailRepository(IDbContextProvider<IhaleProjectDbContext> dbContextProvider):base(dbContextProvider)
		{

		}
	}
}
