using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Application.Contracts.Birim;
using System.Collections.Generic;

namespace IhaleProject.Web.Models.AlimTuru
{
	public class AlimTuruListViewModel
	{
		public IEnumerable<AlimTuruDTO> alimTurleri { get; set; }
	}
}
