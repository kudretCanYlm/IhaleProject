using Abp.Application.Services;
using IhaleProject.Domain.Birim;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IhaleProject.Application.Contracts.Birim
{
    public interface IBirimAppService:IApplicationService
    {
        Task<BirimDto> GetAsync(Guid id);

        Task<IEnumerable<BirimDto>> GetAllAsync();

        Task<BirimEntity> GetEntityAsync(Guid id);

        //Task<IEnumerable<BirimDto>> GetByFilter(Expression<Func<BirimEntity,bool>> filter);

        Task<BirimDto> CreateAsync(CreateBirimDto input);

        Task UpdateAsync(Guid id, UpdateBirimDto input);

        Task DeleteAsync(Guid id);
    }
}
