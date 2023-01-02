using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using IhaleProject.Domain.Ihale;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IhaleProject.Ihale
{
	public class IhaleAppService : IhaleProjectAppServiceBase, IIhaleAppService
	{
		private readonly IIhaleRepository ihaleRepository;

		public IhaleAppService(IIhaleRepository ihaleRepository)
		{
			this.ihaleRepository = ihaleRepository;
		}

		public async Task<IhaleDto> CreateAsync(CreateIhaleDto input)
		{
			var ihale = ObjectMapper.Map<IhaleEntity>(input);
			var ihaleDto = await ihaleRepository.InsertAsync(ihale);

			return ObjectMapper.Map<IhaleDto>(ihaleDto);
		}

		public async Task DeleteAsync(Guid id)
		{
			await ihaleRepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<IhaleDto>> GetAllAsync()
		{
			var ihaleler = await ihaleRepository.GetAllForIhaleDto();

			var ihalelerDto = ObjectMapper.Map<IEnumerable<IhaleDto>>(ihaleler);
			return ihalelerDto;
		}

		public async Task<IhaleDto> GetAsync(Guid id)
		{
			var ihale = await ihaleRepository.GetAsync(id);

			return ObjectMapper.Map<IhaleDto>(ihale);
		}

		public async Task<IhaleFileDto> GetFile(Guid id)
		{
			var ihale = await ihaleRepository.GetAsync(id);

			return ObjectMapper.Map<IhaleFileDto>(ihale);
		}

		public async Task UpdateAsync(Guid id, UpdateIhaleDto input)
		{
			var ihale = await ihaleRepository.GetAsync(id);
			await ihaleRepository.UpdateAsync(ihale);
		}
	}
}
