using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;
using IhaleProject.Domain.Birim;
using IhaleProject.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Birim
{
    public class EfCoreBirimRepository : EfCoreRepositoryBase<IhaleProjectDbContext, BirimEntity, Guid>, IBirimRepository
    {
        public EfCoreBirimRepository(IDbContextProvider<IhaleProjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
