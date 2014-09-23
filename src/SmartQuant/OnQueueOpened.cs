// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class OnQueueOpened : Event
    {
        private EventQueue queue;

        public override byte TypeId
        {
            get
            {
                return EventType.OnQueueOpened;
            }
        }

        public OnQueueOpened(EventQueue queue)
        {
            this.DateTime = DateTime.MinValue;
            this.queue = queue;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
