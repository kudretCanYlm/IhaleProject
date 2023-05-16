using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;
using Microsoft.AspNetCore.Http;
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
		public Guid Id { get; set; }
		public string IhaleNo { get; set; }
		public string IhaleAdi { get; set; }
		public DateTime BaslangicTarihi { get; set; }
		public DateTime BitisTarihi { get; set; }
		public bool IhaleAktifMi { get; set; }
		public string BirimAdi { get; set; }
		public string AlimTuruAdi { get; set; }
		public string AlimUsuluAdi { get; set; }
	}
}
