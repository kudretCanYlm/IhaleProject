using IhaleProject.Application.Contracts.Birim;
using System.Collections.Generic;

namespace IhaleProject.Web.Models.Birim
{
    public class BirimListViewModel
    {
        public IEnumerable<BirimDto> Birims { get; set; }
    }
}
