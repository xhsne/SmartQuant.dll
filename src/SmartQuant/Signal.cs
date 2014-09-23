// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class Signal
    {
        public double Value { get; private set; }

        public Signal(double value)
        {
            this.Value = value;
        }
    }
}
