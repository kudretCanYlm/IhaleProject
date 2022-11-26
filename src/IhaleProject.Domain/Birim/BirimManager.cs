using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Domain.Birim
{
    public class BirimManager:DomainService
    {
        private readonly IBirimRepository birimRepository;

        public BirimManager(IBirimRepository birimRepository)
        {
            this.birimRepository = birimRepository;
        }

    }
}
