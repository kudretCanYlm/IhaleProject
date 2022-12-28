using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using Microsoft.AspNetCore.Http;
using System;

namespace IhaleProject.Web.Models.Ihale
{
	public class IhalePostModel
	{
		public string IhaleNo { get; set; }
		public string IhaleAdi { get; set; }
		public DateTime BaslangicTarihi { get; set; }
		public DateTime BitisTarihi { get; set; }
		//public string DosyaAdi { get; set; }
		//public string DosyaUzantisi { get; set; }
		//public string base64String { get; set; }
		public IFormFile file { get; set; }
		public bool IhaleAktifMi { get; set; } = true;
		public Guid BirimId { get; set; }
		public Guid AlimTuruId { get; set; }
		public Guid AlimUsuluId { get; set; }
	}
}
