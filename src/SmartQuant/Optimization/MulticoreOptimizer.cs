// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.
using System;

namespace SmartQuant.Optimization
{
    public class MulticoreOptimizer
    {
        public long Elapsed
        {
            get
            {
				throw new NotImplementedException ();
            }
        }

		public long EventCount { get; private set; }

        public MulticoreOptimizer()
        {
        }

        public OptimizationParameterSet Optimize(Strategy strategy, InstrumentList instruments, OptimizationUniverse universe, int bunch = -1)
        {
			throw new NotImplementedException ();
        }
	}
}
