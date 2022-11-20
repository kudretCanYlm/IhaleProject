using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Domain.Birim
{
    public interface IBirimRepository:IRepository<BirimEntity,Guid>
    {
        
    }
}
