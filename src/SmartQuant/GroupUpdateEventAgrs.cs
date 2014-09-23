// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class GroupUpdateEventAgrs : EventArgs
    {
        public GroupUpdate GroupUpdate { get; private set; }

        public GroupUpdateEventAgrs(GroupUpdate groupUpdate)
        {
            this.GroupUpdate = groupUpdate;
        }
    }
}
