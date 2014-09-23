// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class SimulatorProgressEventArgs : EventArgs
    {
        public long Count { get; private set; }
        public int Percent { get; private set; }

        public SimulatorProgressEventArgs(long count, int percent)
        {
            this.Count = count;
            this.Percent = percent;
        }
    }
}
