using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.Birim;
using IhaleProject.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.AlimTuru
{
	internal class EFCoreAlimTuruRepository : EfCoreRepositoryBase<IhaleProjectDbContext, AlimTuruEntity, Guid>, IAlimTuruRepository
	{
		public EFCoreAlimTuruRepository(IDbContextProvider<IhaleProjectDbContext> dbContextProvider) : base(dbContextProvider)
		{
		}
	}
}
