﻿using AutoMapper;
using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Application.Contracts.AlimUsulu;
using IhaleProject.Application.Contracts.Birim;
using IhaleProject.Application.Contracts.Email;
using IhaleProject.Application.Contracts.Ihale;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using IhaleProject.Domain.Email;
using IhaleProject.Domain.Ihale;
using System;

namespace IhaleProject
{
	public class IhaleProjectApplicationAutoMapperProfile : Profile
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
			CreateMap<IhaleEntity, IhaleDto>()
				.ForMember(x => x.AlimTuruAdi, opt => opt.MapFrom(opt => opt.alimTuru.AlimTuru))
				.ForMember(x => x.AlimUsuluAdi, opt => opt.MapFrom(opt => opt.alimUsulu.AlimUsulu))
				.ForMember(x => x.BirimAdi, opt => opt.MapFrom(opt => opt.Birim.BirimAdi));

			CreateMap<IhaleEntity, IhaleFileDto>();

			CreateMap<CreateIhaleDto, IhaleEntity>().
				ForMember(x => x.Bytes, opt => opt.MapFrom(opt => Convert.FromBase64String(opt.base64String)));


			CreateMap<IhalePostModelNoFile, UpdateIhaleDto>()
				.ForMember(x => x.BaslangicTarihi, opt => opt.MapFrom(opt => DateTime.Parse(string.Format("{0}.{1}.{2} {3}:{4}:{5}", opt.BaslangicTarihi.Day, opt.BaslangicTarihi.Month, opt.BaslangicTarihi.Year, opt.BaslangicSaati.Hour, opt.BaslangicSaati.Minute, opt.BaslangicSaati.Second))))
				.ForMember(x => x.BitisTarihi, opt => opt.MapFrom(opt => DateTime.Parse(string.Format("{0}.{1}.{2} {3}:{4}:{5}", opt.BitisTarihi.Day, opt.BitisTarihi.Month, opt.BitisTarihi.Year, opt.BitisSaati.Hour, opt.BitisSaati.Minute, opt.BitisTarihi.Second))));


			CreateMap<UpdateIhaleDto, IhaleEntity>();


			CreateMap<IhalePostModel, CreateIhaleDto>()
				.ForMember(x => x.base64String, opt => opt.MapFrom(opt => IhalePostModel.IFormFileToBase64(opt.File)))
				.ForMember(x => x.DosyaAdi, opt => opt.MapFrom(opt => opt.File.FileName))
				.ForMember(x => x.DosyaUzantisi, opt => opt.MapFrom(opt => opt.File.ContentType))
				.ForMember(x => x.BaslangicTarihi, opt => opt.MapFrom(opt => DateTime.Parse(string.Format("{0}.{1}.{2} {3}:{4}:{5}", opt.BaslangicTarihi.Day, opt.BaslangicTarihi.Month, opt.BaslangicTarihi.Year, opt.BaslangicSaati.Hour, opt.BaslangicSaati.Minute, opt.BaslangicSaati.Second))))
				.ForMember(x => x.BitisTarihi, opt => opt.MapFrom(opt => DateTime.Parse(string.Format("{0}.{1}.{2} {3}:{4}:{5}", opt.BitisTarihi.Day, opt.BitisTarihi.Month, opt.BitisTarihi.Year, opt.BitisSaati.Hour, opt.BitisSaati.Minute, opt.BitisTarihi.Second))));

			CreateMap<IhaleEntity, IhalePostUpdateModel>()
				.ForMember(x => x.BaslangicTarihi, opt => opt.MapFrom(opt => string.Format(opt.BaslangicTarihi.ToString("yyyy-MM-dd"))))
				.ForMember(x => x.BaslangicSaati, opt => opt.MapFrom(opt => string.Format(opt.BaslangicTarihi.ToString("HH:mm"))))
				.ForMember(x => x.BitisTarihi, opt => opt.MapFrom(opt => string.Format(opt.BitisTarihi.ToString("yyyy-MM-dd"))))
				.ForMember(x => x.BitisSaati, opt => opt.MapFrom(opt => string.Format(opt.BitisTarihi.ToString("HH:mm"))));

			CreateMap<IhaleEntity, IhaleArsivDto>()
				.ForMember(x => x.AlimTuruAdi, opt => opt.MapFrom(opt => opt.alimTuru.AlimTuru))
				.ForMember(x => x.AlimUsuluAdi, opt => opt.MapFrom(opt => opt.alimUsulu.AlimUsulu))
				.ForMember(x => x.BirimAdi, opt => opt.MapFrom(opt => opt.Birim.BirimAdi))
				.ForMember(x => x.ArsiveEklenmeTarihi, opt => opt.MapFrom(opt =>  string.Format("{0:yyyy-MM-dd hh:mm:ss}",opt.ArsiveEklenmeTarihi)));

			CreateMap<IhaleEntity, IhaleTumDto>()
				.ForMember(x => x.AlimTuruAdi, opt => opt.MapFrom(opt => opt.alimTuru.AlimTuru))
				.ForMember(x => x.AlimUsuluAdi, opt => opt.MapFrom(opt => opt.alimUsulu.AlimUsulu))
				.ForMember(x => x.BirimAdi, opt => opt.MapFrom(opt => opt.Birim.BirimAdi))
				.ForMember(x => x.State, opt => opt.MapFrom(opt=>Enum.GetName(typeof(IhaleStateEnum), opt.IhaleState)));

			//Email
			CreateMap<CreateEmailDto, EmailEntity>();
		}
	}
}
