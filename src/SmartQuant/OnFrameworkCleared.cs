// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnFrameworkCleared : Event
    {
        internal Framework framework;

        public override byte TypeId
        {
            get
            {
                return EventType.OnFrameworkCleared;
            }
        }

        public OnFrameworkCleared(Framework framework)
        {
            this.framework = framework;
        }
    }
}
