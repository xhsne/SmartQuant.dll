// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class InstrumentDefinitionEventArgs : EventArgs
    {
        public InstrumentDefinition Definition { get; private set; }

        public InstrumentDefinitionEventArgs(InstrumentDefinition definition)
        {
            this.Definition = definition;
        }
    }
}
