using System;
using Abp.Domain.Repositories;

namespace IhaleProject.Domain.Ihale
{
	public interface IIhaleRepository: IRepository<IhaleEntity,Guid>
	{
	}
}
