using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using IhaleProject.Domain.AlimTuru;
using IhaleProject.Domain.AlimUsulu;
using IhaleProject.Domain.Birim;

namespace IhaleProject.Domain.İhale
{
	public class İhaleEntity:FullAuditedAggregateRoot<Guid>
	{
		public int İhaleNo { get; set; }
		public string İhaleAdi { get; set; }
		BirimEntity Birim { get; set; }
		AlimTuruEntity alımTuru { get; set; }
		AlimUsuluEntity alımUsulu { get; set; }


		public DateTime BaslangicTarihi { get; set; }
		public DateTime BitisTarihi { get; set; }
		public DateTime BaslangicSaati { get; set; }
		public DateTime BitisSaati { get; set; }

		public string Detay { get; set; }

		public bool İhaleStatus { get; set; }


	}
}
