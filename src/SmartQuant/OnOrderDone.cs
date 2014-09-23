// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnOrderDone : Event
    {
        internal Order Order { get; private set; }

        public override byte TypeId
        {
            get
            {
                return EventType.OnOrderDone;
            }
        }

        public OnOrderDone(Order order)
        {
            this.Order = order;
        }
    }
}
