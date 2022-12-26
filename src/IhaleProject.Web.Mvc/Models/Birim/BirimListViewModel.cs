using IhaleProject.Application.Contracts.AlimUsulu;
using IhaleProject.Application.Contracts.Birim;
using System.Collections.Generic;

namespace IhaleProject.Web.Models.Birim
{
    public class BirimListViewModel
    {
        public IEnumerable<BirimDto> Birims { get; set; }
		public IEnumerable<AlimUsuluDTO> alimUsullleri { get; internal set; }
	}
}
