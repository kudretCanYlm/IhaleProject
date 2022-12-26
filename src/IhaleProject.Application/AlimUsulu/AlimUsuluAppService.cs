using IhaleProject.Application.Contracts.AlimUsulu;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.AlimUsulu
{
	public class AlimUsuluAppService : IhaleProjectAppServiceBase, IAlimUsuluAppService
	{
		private readonly IAlimUsuluRepository alimUsuluRepository;

		public AlimUsuluAppService(IAlimUsuluRepository alimUsuluRepository)
		{
			this.alimUsuluRepository = alimUsuluRepository;
		}

		public async Task<AlimUsuluDTO> CreateAsync(CreateAlimUsuluDTO input)
		{
			input.AlimUsulu = input.AlimUsulu.ToLower();
			var alimUsulu = ObjectMapper.Map<AlimUsuluEntity>(input);
			var alimUsuluDto=await alimUsuluRepository.InsertAsync(alimUsulu);

			return ObjectMapper.Map<AlimUsuluDTO>(alimUsuluDto);
		}

		public async Task DeleteAsync(Guid id)
		{
			await alimUsuluRepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<AlimUsuluDTO>> GetAllAsync()
		{
			var alimUsulleri = await alimUsuluRepository.GetAllListAsync();
			var alimUsulleriDto = ObjectMapper.Map<IEnumerable<AlimUsuluDTO>>(alimUsulleri);
			return alimUsulleriDto;
		}

		public async Task<AlimUsuluDTO> GetAsync(Guid id)
		{
			var alimUsulu = await alimUsuluRepository.GetAsync(id);

			return ObjectMapper.Map<AlimUsuluDTO>(alimUsulu);
		}

		//public async Task<IEnumerable<AlimUsuluDTO>> GetByFilter(Expression<Func<AlimUsuluEntity, bool>> filter)
		//{
		//	var alimUsulleri = await alimUsuluRepository.GetAllListAsync(filter);
		//	var alimUsulleriDto = ObjectMapper.Map<IEnumerable<AlimUsuluDTO>>(alimUsulleri);
		//	return alimUsulleriDto;
		//}

		public async Task UpdateAsync(Guid id, UpdateAlimUsuluDTO input)
		{
			var alimUsulu = await alimUsuluRepository.GetAsync(id);
			alimUsulu.AlimUsulu = input.AlimUsulu.ToLower();
			await alimUsuluRepository.UpdateAsync(alimUsulu);
		}
	}
}
