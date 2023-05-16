﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IhaleProject.Domain.AlimUsulu
{
	public class AlimUsuluEntity: FullAuditedAggregateRoot<Guid>
	{
		public string AlimUsulu { get; set; }
	}
}
