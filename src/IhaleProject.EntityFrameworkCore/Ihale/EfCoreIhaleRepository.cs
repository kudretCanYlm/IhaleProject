using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using IhaleProject.Domain.Ihale;
using IhaleProject.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IhaleProject.Ihale
{
	public class EfCoreIhaleRepository:EfCoreRepositoryBase<IhaleProjectDbContext,IhaleEntity,Guid>,IIhaleRepository
	{
		public EfCoreIhaleRepository(IDbContextProvider<IhaleProjectDbContext> dbContextProvider):base(dbContextProvider)
		{

		}

		public async Task<IEnumerable<IhaleEntity>> GetAllForIhaleDto()
		{
			var ihaleler = await GetAll()
				.Include(x => x.alimTuru)
				.Include(x => x.Birim)
				.Include(x => x.alimUsulu)
				.ToListAsync();

			return ihaleler;
		}
	}
}
