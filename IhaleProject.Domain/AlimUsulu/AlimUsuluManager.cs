using Abp.Domain.Services;

namespace IhaleProject.Domain.AlimUsulu
{
	public class AlimUsuluManager: DomainService
	{
		private readonly IAlimUsuluRepository alimUsuluRepository;

		public AlimUsuluManager(IAlimUsuluRepository alimUsuluRepository)
		{
			this.alimUsuluRepository = alimUsuluRepository;
		}
	}
}
