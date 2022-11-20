using AutoMapper;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Domain.Birim;

namespace IhaleProject
{
    public class IhaleProjectApplicationAutoMapperProfile:Profile
    {
        public IhaleProjectApplicationAutoMapperProfile()
        {
            //Birim
            CreateMap<BirimEntity, BirimDto>();
            CreateMap<CreateBirimDto, BirimEntity>();
            CreateMap<UpdateBirimDto, BirimEntity>();
        }
    }
}
