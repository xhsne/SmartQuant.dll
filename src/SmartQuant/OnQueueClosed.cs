// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class OnQueueClosed : Event
    {
        public override byte TypeId
        {
            get
            {
                return EventType.OnQueueClosed;
            }
        }

        public OnQueueClosed()
        {
            this.DateTime = DateTime.MinValue;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
