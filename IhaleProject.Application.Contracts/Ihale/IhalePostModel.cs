using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace IhaleProject.Application.Contracts.Ihale
{
	public class IhalePostModel
	{
		public string IhaleNo { get; set; }
		public string IhaleAdi { get; set; }
		public DateTime BaslangicTarihi { get; set; }
		public DateTime BaslangicSaati { get; set; }
		public DateTime BitisTarihi { get; set; }
		public DateTime BitisSaati { get; set; }
		public IFormFile? File { get; set; }
		public bool IhaleAktifMi { get; set; }
		public Guid BirimId { get; set; }
		public Guid AlimTuruId { get; set; }
		public Guid AlimUsuluId { get; set; }

		public static string IFormFileToBase64(IFormFile file)
		{
			string base64 = "";

			if (file == null)
			{
				return base64;
			}


			if (file.Length > 0)
			{
				using (var ms = new MemoryStream())
				{
					file.CopyTo(ms);
					var fileBytes = ms.ToArray();
					base64 = Convert.ToBase64String(fileBytes);

				}
			}

			return base64;


		}
	}
	public class IhalePostModelNoFile
	{
		public string IhaleNo { get; set; }
		public string IhaleAdi { get; set; }
		public DateTime BaslangicTarihi { get; set; }
		public DateTime BaslangicSaati { get; set; }
		public DateTime BitisTarihi { get; set; }
		public DateTime BitisSaati { get; set; }
		public bool IhaleAktifMi { get; set; }
		public Guid BirimId { get; set; }
		public Guid AlimTuruId { get; set; }
		public Guid AlimUsuluId { get; set; }

	}

	public class IhalePostModelValidator : AbstractValidator<IhalePostModel>
	{
		public IhalePostModelValidator()
		{
			RuleFor(x => x.IhaleNo)
				.NotEmpty().WithMessage("İhale No boş olamaz")
				.NotNull().WithMessage("İhale No boş olamaz")
				.Length(1, 50).WithMessage("İhale No uzunluğu 1-50 karakter arası olmalı");

			RuleFor(x => x.IhaleAdi)
				.NotEmpty().WithMessage("İhale Adı boş olamaz")
				.NotNull().WithMessage("İhale Adı boş olamaz")
				.Length(1, 50).WithMessage("İhale Adı uzunluğu 1-50 karakter arası olmalı");

			RuleFor(x => x.BaslangicTarihi)
				.NotEmpty().WithMessage("Baslangiç Tarihi boş olamaz")
				.NotNull().WithMessage("Baslangiç Tarihi boş olamaz");

			RuleFor(x => x.BaslangicSaati)
				.NotEmpty().WithMessage("Baslangiç Saati boş olamaz")
				.NotNull().WithMessage("Baslangiç Saati boş olamaz");

			RuleFor(x => x.BitisTarihi)
				.NotEmpty().WithMessage("Bitiş Tarihi boş olamaz")
				.NotNull().WithMessage("Bitiş Tarihi boş olamaz");

			RuleFor(x => x.BitisSaati)
				.NotEmpty().WithMessage("Bitiş Saati boş olamaz")
				.NotNull().WithMessage("Bitiş Saati boş olamaz");

			RuleFor(x => x.BirimId)
				.NotEmpty().WithMessage("Birim boş olamaz")
				.NotNull().WithMessage("Birim boş olamaz")
				.Must(g => Guid.TryParse(g.ToString(), out _) == true).WithMessage("Birim boş olamaz")
				.Must(g => g.ToString() != "-1").WithMessage("Birim boş olamaz");

			RuleFor(x => x.AlimTuruId)
				.NotEmpty().WithMessage("Alım Türü boş olamaz")
				.NotNull().WithMessage("Alım Türü boş olamaz")
				.Must(g => Guid.TryParse(g.ToString(), out _) == true).WithMessage("Alım Türü boş olamaz")
				.Must(g => g.ToString() != "-1").WithMessage("Alım Türü boş olamaz");

			RuleFor(x => x.AlimUsuluId)
				.NotEmpty().WithMessage("Alım Üsulu boş olamaz")
				.NotNull().WithMessage("Alım Üsulu boş olamaz")
				.Must(g => Guid.TryParse(g.ToString(), out _) == true).WithMessage("Alım Üsulu boş olamaz")
				.Must(g => g.ToString() != "-1").WithMessage("Alım Üsulu boş olamaz");

			RuleFor(x => x.File)
				.NotEmpty().WithMessage("Lütfen dosya ekleyeniz")
				.NotNull().WithMessage("Lütfen dosya ekleyeniz");

		}
	}

	public class IhalePostModelNoFileValidator : AbstractValidator<IhalePostModelNoFile>
	{
		public IhalePostModelNoFileValidator()
		{
			RuleFor(x => x.IhaleNo)
				.NotEmpty().WithMessage("İhale No boş olamaz")
				.NotNull().WithMessage("İhale No boş olamaz")
				.Length(1, 50).WithMessage("İhale No uzunluğu 1-50 karakter arası olmalı");

			RuleFor(x => x.IhaleAdi)
				.NotEmpty().WithMessage("İhale Adı boş olamaz")
				.NotNull().WithMessage("İhale Adı boş olamaz")
				.Length(1, 50).WithMessage("İhale Adı uzunluğu 1-50 karakter arası olmalı");

			RuleFor(x => x.BaslangicTarihi)
				.NotEmpty().WithMessage("Baslangiç Tarihi boş olamaz")
				.NotNull().WithMessage("Baslangiç Tarihi boş olamaz");

			RuleFor(x => x.BaslangicSaati)
				.NotEmpty().WithMessage("Baslangiç Saati boş olamaz")
				.NotNull().WithMessage("Baslangiç Saati boş olamaz");

			RuleFor(x => x.BitisTarihi)
				.NotEmpty().WithMessage("Bitiş Tarihi boş olamaz")
				.NotNull().WithMessage("Bitiş Tarihi boş olamaz");

			RuleFor(x => x.BitisSaati)
				.NotEmpty().WithMessage("Bitiş Saati boş olamaz")
				.NotNull().WithMessage("Bitiş Saati boş olamaz");

			RuleFor(x => x.BirimId)
				.NotEmpty().WithMessage("Birim boş olamaz")
				.NotNull().WithMessage("Birim boş olamaz")
				.Must(g => Guid.TryParse(g.ToString(), out _) == true).WithMessage("Birim boş olamaz")
				.Must(g => g.ToString() != "-1").WithMessage("Birim boş olamaz");

			RuleFor(x => x.AlimTuruId)
				.NotEmpty().WithMessage("Alım Türü boş olamaz")
				.NotNull().WithMessage("Alım Türü boş olamaz")
				.Must(g => Guid.TryParse(g.ToString(), out _) == true).WithMessage("Alım Türü boş olamaz")
				.Must(g => g.ToString() != "-1").WithMessage("Alım Türü boş olamaz");

			RuleFor(x => x.AlimUsuluId)
				.NotEmpty().WithMessage("Alım Üsulu boş olamaz")
				.NotNull().WithMessage("Alım Üsulu boş olamaz")
				.Must(g => Guid.TryParse(g.ToString(), out _) == true).WithMessage("Alım Üsulu boş olamaz")
				.Must(g => g.ToString() != "-1").WithMessage("Alım Üsulu boş olamaz");

		}
	}

}
