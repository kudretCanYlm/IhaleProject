using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace IhaleProject.Domain.Ihale
{
	public interface IIhaleRepository: IRepository<IhaleEntity,Guid>
	{
		Task<IEnumerable<IhaleEntity>> GetAllForIhaleDto();
	}
}
