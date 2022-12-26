using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using IhaleProject.Domain.Ihale;
using IhaleProject.EntityFrameworkCore;
using System;

namespace IhaleProject.Ihale
{
	public class EfCoreIhaleRepository:EfCoreRepositoryBase<IhaleProjectDbContext,IhaleEntity,Guid>,IIhaleRepository
	{
		public EfCoreIhaleRepository(IDbContextProvider<IhaleProjectDbContext> dbContextProvider):base(dbContextProvider)
		{

		}
	}
}
