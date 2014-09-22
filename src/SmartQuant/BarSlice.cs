// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class BarSlice : Event
    {
        private long size;

        public override byte TypeId
        {
            get
            {
                return EventType.BarSlice;
            }
        }

        public long Size
        {
            get
            {
                return this.size;
            }
        }
            
        public BarSlice(long size)
        {
            this.size = size;
        }
    }
}
