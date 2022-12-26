using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.Birim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.AlimTuru
{
    public class AlimTuruAppService: IhaleProjectAppServiceBase, IAlimTuruAppService
	{
		private readonly IAlimTuruRepository alimTuruRepository;
		//private readonly BirimManager birimManager;

		public AlimTuruAppService(IAlimTuruRepository alimTuruRepository)
		{
			this.alimTuruRepository = alimTuruRepository;

		}

		// [Authorize()]
		public async Task<AlimTuruDTO> CreateAsync(CreateAlimTuruDTO input)
		{
			input.AlimTuru = input.AlimTuru.ToLower();
			var alimTuru = ObjectMapper.Map<AlimTuruEntity>(input);
			var alimTuruDto = await alimTuruRepository.InsertAsync(alimTuru);

			return ObjectMapper.Map<AlimTuruDTO>(alimTuruDto);
		}

		// [Authorize()]
		public async Task DeleteAsync(Guid id)
		{
			await alimTuruRepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<AlimTuruDTO>> GetAllAsync()
		{
			var alimTurleri = await alimTuruRepository.GetAllListAsync();
			var alimTurleriDto = ObjectMapper.Map<IEnumerable<AlimTuruDTO>>(alimTurleri);
			return alimTurleriDto;	
		}

		//public async Task<IEnumerable<AlimTuruDTO>> GetByFilter(Expression<Func<AlimTuruEntity, bool>> filter)
		//{
		//	var alimTurleri = await alimTuruRepository.GetAllListAsync(filter);
		//	var alimTurleriDto = ObjectMapper.Map<IEnumerable<AlimTuruDTO>>(alimTurleri);
		//	return alimTurleriDto;
		//}

		public async Task<AlimTuruDTO> GetAsync(Guid id)
		{
			var alimTuru = await alimTuruRepository.GetAsync(id);

			return ObjectMapper.Map<AlimTuruDTO>(alimTuru);
		}

		// [Authorize()]
		public async Task UpdateAsync(Guid id, UpdateAlimTuruDTO input)
		{
			var alimTuru = await alimTuruRepository.GetAsync(id);
			alimTuru.AlimTuru = input.AlimTuru.ToLower();
			await alimTuruRepository.UpdateAsync(alimTuru);
		}
	}
}
