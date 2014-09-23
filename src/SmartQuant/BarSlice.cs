// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class BarSlice : Event
    {
        public override byte TypeId
        {
            get
            {
                return EventType.BarSlice;
            }
        }

        public long Size { get; private set; }

        public BarSlice(long size)
        {
            this.Size = size;
        }
    }
}
