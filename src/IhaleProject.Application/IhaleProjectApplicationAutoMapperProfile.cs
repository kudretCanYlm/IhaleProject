using AutoMapper;
using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Application.Contracts.AlimUsulu;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using IhaleProject.Domain.Ihale;
using System;

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
            CreateMap<IhalePostModel, CreateIhaleDto>()
                .ForMember(x => x.base64String, opt => opt.MapFrom(opt => IhalePostModel.IFormFileToBase64(opt.File)))
                .ForMember(x => x.DosyaAdi, opt => opt.MapFrom(opt => opt.File.FileName))
                .ForMember(x => x.DosyaUzantisi, opt => opt.MapFrom(opt => opt.File.ContentType))
                .ForMember(x => x.BaslangicTarihi, opt => opt.MapFrom(opt => DateTime.Parse(string.Format("{0}.{1}.{2} {3}:{4}:{5}", opt.BaslangicTarihi.Day , opt.BaslangicTarihi.Month, opt.BaslangicTarihi.Year, opt.BaslangicSaati.Hour , opt.BaslangicSaati.Minute, opt.BaslangicSaati.Second))))
                .ForMember(x => x.BitisTarihi, opt => opt.MapFrom(opt => DateTime.Parse(string.Format("{0}.{1}.{2} {3}:{4}:{5}", opt.BitisTarihi.Day,opt.BitisTarihi.Month,opt.BitisTarihi.Year, opt.BitisSaati.Hour , opt.BitisSaati.Minute,opt.BitisTarihi.Second))));
                

		}
	}
}
