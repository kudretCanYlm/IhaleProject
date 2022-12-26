using AutoMapper;
using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Application.Contracts.AlimUsulu;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using IhaleProject.Domain.Ihale;

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

            //AlimTuru
            CreateMap<AlimTuruEntity, AlimTuruDTO>();
            CreateMap<CreateAlimTuruDTO, AlimTuruEntity>();
            CreateMap<UpdateAlimTuruDTO, AlimTuruEntity>();

            //AlimUsulu
            CreateMap<AlimUsuluEntity, AlimUsuluDTO>();
            CreateMap<CreateAlimUsuluDTO, AlimUsuluEntity>();
            CreateMap<UpdateAlimUsuluDTO, AlimUsuluEntity>();

            //Ihale
            CreateMap<IhaleEntity, IhaleDto>();
            CreateMap<CreateIhaleDto, IhaleEntity>();
            CreateMap<UpdateIhaleDto,IhaleEntity>();
        }
    }
}
