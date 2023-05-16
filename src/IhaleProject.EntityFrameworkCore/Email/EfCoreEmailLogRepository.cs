using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using IhaleProject.Domain.Email;
using IhaleProject.EntityFrameworkCore;
using System;

namespace IhaleProject.Email
{
	internal class EfCoreEmailLogRepository : EfCoreRepositoryBase<IhaleProjectDbContext, EmailLogEntity, Guid>, IEmailLogRepository
	{
		public EfCoreEmailLogRepository(IDbContextProvider<IhaleProjectDbContext> dbContextProvider) : base(dbContextProvider)
		{

		}
	}
}
