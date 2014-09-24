// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections;
using System.Collections.Generic;

namespace SmartQuant.Optimization
{
    public class OptimizationParameterSet : IEnumerable<OptimizationParameter>, IEnumerable
    {
        private List<OptimizationParameter> parameters = new List<OptimizationParameter>();

        public double Objective { get; set; }

        public OptimizationParameter this [int index]
        {
            get
            {
                return this.parameters[index];
            }
        }

        public void Add(OptimizationParameter parameter)
        {
            this.parameters.Add(parameter);
        }

        public void Add(string name, double value)
        {
            this.parameters.Add(new OptimizationParameter(name, value));
        }

        public IEnumerator<OptimizationParameter> GetEnumerator()
        {
            return this.parameters.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.parameters.GetEnumerator();
        }

        public override string ToString()
        {
            string s = "";
            foreach (OptimizationParameter param in this.parameters)
                s = s + param.Name + " = " + param.Value + " ";
            return s;
        }
    }
}
