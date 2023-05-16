using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IhaleProject.Application.Contracts.Ihale
{
	public interface IIhaleAppService:IApplicationService
	{
		Task<IEnumerable<IhaleDto>> GetYayindakiIlanlar();
		Task<IEnumerable<IhaleTumDto>> GetTumIhaleler();
		Task<IEnumerable<IhaleDto>> GetKaldirimisIhaleler();
		Task<IEnumerable<IhaleDto>> GetIlanSuresiBitmisYayinlar();
		Task<IEnumerable<IhaleArsivDto>> GetArsivliIhaleler();
		Task<IhaleDto> GetAsync(Guid id);
		Task ArsiveEkle(Guid id);
		Task<IhalePostUpdateModel> GetUpdateModelAsync(Guid id);

		Task<IEnumerable<IhaleDto>> GetAllAsync();

		Task<IhaleDto> CreateAsync(CreateIhaleDto input);

		Task UpdateAsync(Guid id, UpdateIhaleDto input);

		Task DeleteAsync(Guid id);
		Task YayindanKaldir(Guid id);
		Task TekrarYayinla(Guid id);

		Task<IhaleFileDto> GetFile(Guid id);
	}
}
