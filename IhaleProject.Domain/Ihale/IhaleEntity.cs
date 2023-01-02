using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;

namespace IhaleProject.Domain.Ihale
{
	public class IhaleEntity:FullAuditedAggregateRoot<Guid>
	{
		public string IhaleNo { get; set; }
		public string IhaleAdi { get; set; }
		public DateTime BaslangicTarihi { get; set; }
		public DateTime BitisTarihi { get; set; }

		public string DosyaAdi { get; set; }
		public string DosyaUzantisi { get; set; }
		public byte[] Bytes { get; set; }
		public bool IhaleAktifMi { get; set; }
		public Guid BirimId { get; set; }
		public Guid alimTuruId { get; set; }
		public Guid alimUsuluId { get; set; }

		[ForeignKey("BirimId")]
		public BirimEntity Birim { get; set; }

		[ForeignKey("alimTuruId")]
		public AlimTuruEntity alimTuru { get; set; }

		[ForeignKey("alimUsuluId")]
		public AlimUsuluEntity alimUsulu { get; set; }


	}
}
