using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.EntityFrameworkCore;
using System;

namespace IhaleProject.AlimUsulu
{
	public class EfCoreAlimUsuluRepository:EfCoreRepositoryBase<IhaleProjectDbContext,AlimUsuluEntity,Guid>,IAlimUsuluRepository
	{
		public EfCoreAlimUsuluRepository(IDbContextProvider<IhaleProjectDbContext> dbContextProvider):base(dbContextProvider)
		{

		}
	}
}
