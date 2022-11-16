using System.Threading.Tasks;
using Abp.Application.Services;
using IhaleProject.Authorization.Accounts.Dto;

namespace IhaleProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
