using Abp.Domain.Entities.Auditing;
using System;

namespace IhaleProject.Domain.Email
{
	public class EmailLogEntity : FullAuditedAggregateRoot<Guid>
	{
		public string EmailAddress { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
	}
}
