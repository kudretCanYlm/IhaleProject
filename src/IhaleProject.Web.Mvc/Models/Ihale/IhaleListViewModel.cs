using System.Collections.Generic;
using IhaleProject.Application.Contracts.Ihale;

namespace IhaleProject.Web.Models.Ihale
{
    public class IhaleListViewModel
    {
        public IEnumerable<IhaleDto> ihaleler { get; set; }
    }
}
