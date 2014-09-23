// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnEventManagerStep : Event
    {
        public override byte TypeId
        {
            get
            {
                return EventType.OnEventManagerStep;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
