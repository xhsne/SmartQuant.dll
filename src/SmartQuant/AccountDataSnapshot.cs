// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class AccountDataSnapshot
    {
        public AccountDataEntry[] Entries { get; private set; }

        public AccountDataSnapshot(AccountDataEntry[] entries)
        {
            this.Entries = entries;
        }
    }
}
