// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class Signal
    {
        private double value;

        public double Value
        {
            get
            {
                return this.value;
            }
        }

        public Signal(double value)
        {
            this.value = value;
        }
    }
}
