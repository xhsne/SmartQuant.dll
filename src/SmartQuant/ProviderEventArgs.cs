// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class ProviderEventArgs : EventArgs
    {
        public IProvider Provider { get; private set; }

        public ProviderEventArgs(IProvider provider)
        {
            this.Provider = provider;
        }
    }
}
