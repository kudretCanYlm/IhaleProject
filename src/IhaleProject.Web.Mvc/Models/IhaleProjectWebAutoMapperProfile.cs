using AutoMapper;
using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Web.Models.Ihale;

namespace IhaleProject.Web.Models
{
	public class IhaleProjectWebAutoMapperProfile:Profile
	{
		public IhaleProjectWebAutoMapperProfile()
		{
			CreateMap<IhalePostModel, CreateIhaleDto>();
		}
	}
}
