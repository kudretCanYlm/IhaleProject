using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Application.Contracts.Ihale
{
	public class IhaleDto
	{
		public string IhaleNo { get; set; }
		public string IhaleAdi { get; set; }
		public DateTime BaslangicTarihi { get; set; }
		public DateTime BitisTarihi { get; set; }
		public DateTime BaslangicSaati { get; set; }
		public DateTime BitisSaati { get; set; }
		public string DosyaAdi { get; set; }
		public string DosyaUzantisi { get; set; }
		public byte[] Bytes { get; set; }
		public bool IhaleAktifMi { get; set; }
		public string BirimAdi { get; set; }
		public string AlimTuruAdi { get; set; }
		public string AlimUsuluAdi { get; set; }

	}
}
