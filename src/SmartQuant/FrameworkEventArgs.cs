// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class FrameworkEventArgs : EventArgs
    {
        public Framework Framework { get; private set; }

        public FrameworkEventArgs(Framework framework)
        {
            this.Framework = framework;
        }
    }
}
