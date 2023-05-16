using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using IhaleProject.Domain.Ihale;
using IhaleProject.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IhaleProject.Ihale
{
	public class EfCoreIhaleRepository : EfCoreRepositoryBase<IhaleProjectDbContext, IhaleEntity, Guid>, IIhaleRepository
	{
		public EfCoreIhaleRepository(IDbContextProvider<IhaleProjectDbContext> dbContextProvider) : base(dbContextProvider)
		{

		}

		public async Task<IEnumerable<IhaleEntity>> GetAllForIhaleDto()
		{
			var ihaleler = await GetAll()
				.Where(x => x.IhaleArsivliMi == false)
				.Include(x => x.alimTuru)
				.Include(x => x.Birim)
				.Include(x => x.alimUsulu)
				.ToListAsync();

			return ihaleler;
		}

		public  IQueryable<IhaleEntity> GetQueryForActiveIhale()
		{
			var ihaleler =  GetAll()
						.Where(x=>x.IhaleAktifMi==true)
						.Where(x => x.IhaleArsivliMi == false)
						.Include(x => x.alimTuru)
						.Include(x => x.Birim)
						.Include(x => x.alimUsulu).AsQueryable();

			return ihaleler;
		}
	}
}
