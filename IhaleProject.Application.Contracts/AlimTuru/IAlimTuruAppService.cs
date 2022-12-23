using Abp.Application.Services;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.Birim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Application.Contracts.AlimTuru
{
    public interface IAlimTuruAppService : IApplicationService
    {
        //stay on the here
        Task<AlimTuruDTO> GetAsync(Guid id);

        Task<IEnumerable<AlimTuruDTO>> GetAllAsync();

        Task<IEnumerable<AlimTuruDTO>> GetByFilter(Expression<Func<AlimTuruEntity, bool>> filter);

        Task<AlimTuruDTO> CreateAsync(CreateAlimTuruDTO input);

        Task UpdateAsync(Guid id, UpdateAlimTuruDTO input);

        Task DeleteAsync(Guid id);
    }
}
