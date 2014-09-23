// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnOrderStatusChanged : Event
    {
        internal Order Order { get; private set; }

        public override byte TypeId
        {
            get
            {
                return EventType.OnOrderStatusChanged;
            }
        }

        public OnOrderStatusChanged(Order order)
        {
            this.Order = order;
        }
    }
}
