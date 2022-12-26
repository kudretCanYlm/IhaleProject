using IhaleProject.Application.Contracts.AlimTuru;
using IhaleProject.Application.Contracts.AlimUsulu;
using System.Collections.Generic;

namespace IhaleProject.Web.Models.AlimUsulu
{
	public class AlimUsuluListViewModel
	{
		public IEnumerable<AlimUsuluDTO> alimUsulleri { get; set; }
	}
}
