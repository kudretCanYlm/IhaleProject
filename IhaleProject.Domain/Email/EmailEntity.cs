using Abp.Domain.Entities.Auditing;
using System;

namespace IhaleProject.Domain.Email
{
	public class EmailEntity: FullAuditedAggregateRoot<Guid>
	{
		public string Email { get; set; }
	}
}
