// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
	public class DataImport
	{
		private Framework framework;

		public DataImport(Framework framework)
		{
			this.framework = framework;
		}

		public void Import(string fileName, string symbol, int type)
		{
			throw new NotImplementedException ();
		}
	}
}
