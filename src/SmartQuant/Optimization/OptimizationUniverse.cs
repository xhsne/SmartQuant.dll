// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections;
using System.Collections.Generic;

namespace SmartQuant.Optimization
{
    public class OptimizationUniverse : IEnumerable<OptimizationParameterSet>, IEnumerable
    {
        private List<OptimizationParameterSet> sets = new List<OptimizationParameterSet>();

        public int Count
        {
            get
            {
                return this.sets.Count;
            }
        }

        public OptimizationParameterSet this[int index]
        {
            get
            {
                return this.sets[index];
            }
        }

        public void Add(OptimizationParameterSet parameter)
        {
            this.sets.Add(parameter);
        }

        public void Clear()
        {
            this.sets.Clear();
        }

        public IEnumerator<OptimizationParameterSet> GetEnumerator()
        {
            return this.sets.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.sets.GetEnumerator();
        }
    }
}
