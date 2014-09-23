// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class InstrumentEventArgs : EventArgs
    {
        public Instrument Instrument { get; private set; }

        public InstrumentEventArgs(Instrument instrument)
        {
            this.Instrument = instrument;
        }
    }
}
