// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant.Optimization
{
    public class OptimizationParameter
    {
        public string Name { get; set; }

        public double Value { get; set; }

        public OptimizationParameter(string name, double value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}
