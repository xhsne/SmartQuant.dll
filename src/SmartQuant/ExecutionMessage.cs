// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
	public class ExecutionMessage : DataObject
	{
        public Instrument Instrument { get; set; }
        public Order Order { get; set; }
	}

}
