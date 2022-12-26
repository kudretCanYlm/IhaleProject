using Abp.Application.Services;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Application.Contracts.AlimUsulu
{
	public interface IAlimUsuluAppService:IApplicationService
	{
		Task<AlimUsuluDTO> GetAsync(Guid id);

		Task<IEnumerable<AlimUsuluDTO>> GetAllAsync();

		//Task<IEnumerable<AlimUsuluDTO>> GetByFilter(Expression<Func<AlimUsuluEntity, bool>> filter);

		Task<AlimUsuluDTO> CreateAsync(CreateAlimUsuluDTO input);

		Task UpdateAsync(Guid id, UpdateAlimUsuluDTO input);

		Task DeleteAsync(Guid id);
	}
}
