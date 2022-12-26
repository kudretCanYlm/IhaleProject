using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;
using IhaleProject.Domain.Birim;

namespace IhaleProject.Domain.İhale
{
	public class İhaleManager: DomainService
	{
		private readonly IİhaleRepository ihaleRepository;

		public İhaleManager(IİhaleRepository ihaleRepository)
		{
			this.ihaleRepository = ihaleRepository;
		}
	}
}
