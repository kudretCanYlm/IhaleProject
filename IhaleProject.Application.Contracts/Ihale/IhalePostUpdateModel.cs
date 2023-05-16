using System;

namespace IhaleProject.Application.Contracts.Ihale
{
	public class IhalePostUpdateModel
	{
		public string IhaleNo { get; set; }
		public string IhaleAdi { get; set; }
		public string BaslangicTarihi { get; set; }
		public string BaslangicSaati { get; set; }
		public string BitisTarihi { get; set; }
		public string BitisSaati { get; set; }
		public bool IhaleAktifMi { get; set; }
		public Guid BirimId { get; set; }
		public Guid alimTuruId { get; set; }
		public Guid alimUsuluId { get; set; }
	}
}
