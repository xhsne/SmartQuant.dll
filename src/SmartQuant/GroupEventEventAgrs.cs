// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class GroupEventEventAgrs : EventArgs
    {
        public GroupEvent GroupEvent { get; private set; }

        public GroupEventEventAgrs(GroupEvent groupEvent)
        {
            this.GroupEvent = groupEvent;
        }
    }
}
