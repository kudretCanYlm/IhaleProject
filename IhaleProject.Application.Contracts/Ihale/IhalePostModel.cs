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
		public IFormFile File { get; set; }
		public bool IhaleAktifMi { get; set; }
		public Guid BirimId { get; set; }
		public Guid AlimTuruId { get; set; }
		public Guid AlimUsuluId { get; set; }

		public static string IFormFileToBase64(IFormFile file)
		{
			string base64 = "";

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


}
