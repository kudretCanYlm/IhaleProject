using Abp.EntityFrameworkCore.Repositories;
using Castle.MicroKernel;
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
			var ihale= ihaleRepository.Get(id);
			ihale.IhaleState = IhaleStateEnum.Silinmis;

			await ihaleRepository.UpdateAsync(ihale);

			await ihaleRepository.DeleteAsync(id);
		}

		public async Task YayindanKaldir(Guid id)
		{
			var ihale = ihaleRepository.Get(id);
			ihale.IhaleAktifMi = false;
			ihale.IhaleState = IhaleStateEnum.Kaldirilmis;

			await ihaleRepository.UpdateAsync(ihale);
		}

		public async Task TekrarYayinla(Guid id)
		{
			var ihale = ihaleRepository.Get(id);
			ihale.IhaleAktifMi = true;
			ihale.IhaleState = IhaleStateEnum.Aktif;

			await ihaleRepository.UpdateAsync(ihale);
		}

		public async Task<IEnumerable<IhaleDto>> GetAllAsync()
		{
			var ihaleler = await ihaleRepository.GetQueryForActiveIhale().ToListAsync();

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

		public async Task<IEnumerable<IhaleDto>> GetIlanSuresiBitmisYayinlar()
		{
			var ihaleler = await ihaleRepository.GetQueryForActiveIhale().Where(x => x.BitisTarihi < DateTime.Now).ToListAsync();
			return ObjectMapper.Map<IEnumerable<IhaleDto>>(ihaleler);
		}

		public async Task<IEnumerable<IhaleDto>> GetYayindakiIlanlar()
		{
			var ihaleler = await ihaleRepository.GetQueryForActiveIhale().Where(x => x.BitisTarihi >= DateTime.Now).ToListAsync();
			return ObjectMapper.Map<IEnumerable<IhaleDto>>(ihaleler);
		}

		public async Task<IhalePostUpdateModel> GetUpdateModelAsync(Guid id)
		{
			var ihale = await ihaleRepository.GetAsync(id);

			return ObjectMapper.Map<IhalePostUpdateModel>(ihale);
		}

		public async Task UpdateAsync(Guid id, UpdateIhaleDto input)
		{
			var ihale = await ihaleRepository.GetAsync(id);
			await ihaleRepository.UpdateAsync(ihale);
		}

		public async Task<IEnumerable<IhaleArsivDto>> GetArsivliIhaleler()
		{
			var arsivliIhaleler = await ihaleRepository.GetAll()
				.Include(x => x.Birim).Include(x => x.alimTuru).Include(x => x.alimUsulu)
				.Where(x => x.IhaleArsivliMi == true).ToListAsync();

			return ObjectMapper.Map<IEnumerable<IhaleArsivDto>>(arsivliIhaleler);

		}

		public async Task<IEnumerable<IhaleTumDto>> GetTumIhaleler()
		{
			var ihaleler = await ihaleRepository.Query(x => x.Include(x => x.Birim).Include(x => x.alimTuru).Include(x => x.alimUsulu)
				.Where(x => x.IsDeleted == true || x.IsDeleted == false)
				.Where(x => x.IhaleArsivliMi == false).ToListAsync());

			return ObjectMapper.Map<IEnumerable<IhaleTumDto>>(ihaleler);
		}

		public async Task<IEnumerable<IhaleDto>> GetKaldirimisIhaleler()
		{
			var ihaleler = await ihaleRepository.GetAll()
				.Include(x => x.Birim).Include(x => x.alimTuru).Include(x => x.alimUsulu)
				.Where(x => x.IhaleArsivliMi == false).Where(x => x.IhaleAktifMi == false).ToListAsync();

			return ObjectMapper.Map<IEnumerable<IhaleDto>>(ihaleler);
		}

		public async Task ArsiveEkle(Guid id)
		{
			var ihale=await ihaleRepository.GetAsync(id);
			ihale.IhaleArsivliMi = true;
			ihale.ArsiveEklenmeTarihi = DateTime.Now;

			await ihaleRepository.UpdateAsync(ihale);
		}


	}
}
