using Abp.Domain.Services;

namespace IhaleProject.Domain.Ihale
{
	public class IhaleManager: DomainService
	{
		private readonly IIhaleRepository ihaleRepository;

		public IhaleManager(IIhaleRepository ihaleRepository)
		{
			this.ihaleRepository = ihaleRepository;
		}
	}
}
