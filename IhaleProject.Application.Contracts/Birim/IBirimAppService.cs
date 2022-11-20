using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IhaleProject.Domain.Birim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Application.Contracts.Birim
{
    public interface IBirimAppService:IApplicationService
    {
        Task<BirimDto> GetAsync(Guid id);

        Task<IEnumerable<BirimDto>> GetAllAsync();

        Task<IEnumerable<BirimDto>> GetByFilter(Expression<Func<BirimEntity,bool>> filter);

        Task<BirimDto> CreateAsync(CreateBirimDto input);

        Task UpdateAsync(Guid id, UpdateBirimDto input);

        Task DeleteAsync(Guid id);
    }
}
