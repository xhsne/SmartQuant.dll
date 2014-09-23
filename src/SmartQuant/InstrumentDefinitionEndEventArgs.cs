// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class InstrumentDefinitionEndEventArgs : EventArgs
    {
        public InstrumentDefinitionEnd End { get; private set; }

        public InstrumentDefinitionEndEventArgs(InstrumentDefinitionEnd end)
        {
            this.End = end;
        }
    }
}
