using System.Threading.Tasks;
using Abp.Application.Services;
using IhaleProject.Sessions.Dto;

namespace IhaleProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
