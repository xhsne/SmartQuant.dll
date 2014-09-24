// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
	public class CommissionProvider : ICommissionProvider
	{
		public double Commission { get; set; }

		public CommissionType Type { get; set; }

		public double MinCommission { get; set; }

		public virtual double GetCommission (ExecutionReport report)
		{
			throw new NotImplementedException();
		}
	}
}
