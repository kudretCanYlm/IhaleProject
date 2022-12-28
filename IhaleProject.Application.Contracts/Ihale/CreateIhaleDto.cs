using FluentValidation;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using System;

namespace IhaleProject.Application.Contracts.Ihale
{
	public class CreateIhaleDto
	{
		public string IhaleNo { get; set; }
		public string IhaleAdi { get; set; }
		public DateTime BaslangicTarihi { get; set; }
		public DateTime BitisTarihi { get; set; }
		public string DosyaAdi { get; set; }
		public string DosyaUzantisi { get; set; }
		public string base64String { get; set; }
		public bool IhaleAktifMi { get; set; } = true;
		public BirimEntity Birim { get; set; }
		public AlimTuruEntity alimTuru { get; set; }
		public AlimUsuluEntity alimUsulu { get; set; }
	}

	public class CreateIhaleDtoValidator:AbstractValidator<CreateIhaleDto>
	{
		public CreateIhaleDtoValidator()
		{
			RuleFor(x => x.IhaleNo)
				.NotEmpty().WithMessage("İhale No boş olamaz")
				.NotNull().WithMessage("İhale No boş olamaz")
				.Length(1, 50).WithMessage("İhale No uzunluğu 1-50 karakter arası olmalı");
			
			RuleFor(x=>x.IhaleAdi)
				.NotEmpty().WithMessage("İhale Adı boş olamaz")
				.NotNull().WithMessage("İhale Adı boş olamaz")
				.Length(1, 50).WithMessage("İhale Adı uzunluğu 1-50 karakter arası olmalı");

			RuleFor(x => x.BaslangicTarihi)
				.NotEmpty().WithMessage("Baslangiç Tarihi boş olamaz")
				.NotNull().WithMessage("Baslangiç Tarihi boş olamaz");

			RuleFor(x=>x.BitisTarihi)
				.NotEmpty().WithMessage("Bitiş Tarihi boş olamaz")
				.NotNull().WithMessage("Bitiş Tarihi boş olamaz");

			RuleFor(x=>x.DosyaAdi)
				.NotEmpty().WithMessage("Dosya Adı boş olamaz")
				.NotNull().WithMessage("Dosya Adı boş olamaz")
				.Length(1, 50).WithMessage("Dosya Adı uzunluğu 1-50 karakter arası olmalı");

			RuleFor(x=>x.DosyaUzantisi)
				.NotEmpty().WithMessage("Dosya Uzantısı boş olamaz")
				.NotNull().WithMessage("Dosya Uzantısı boş olamaz")
				.Length(1, 50).WithMessage("Dosya Uzantısı uzunluğu 1-50 karakter arası olmalı");

			RuleFor(x => x.base64String)
				.NotEmpty().WithMessage("base64String boş olamaz")
				.NotNull().WithMessage("base64String boş olamaz");

		}
	}

}
