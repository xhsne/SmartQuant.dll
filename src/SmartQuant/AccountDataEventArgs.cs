// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class AccountDataEventArgs : EventArgs
    {
        public AccountData Data { get; private set; }

        public AccountDataEventArgs(AccountData data)
        {
            this.Data = data;
        }
    }
}
