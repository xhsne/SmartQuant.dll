// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class EventFilter
    {
        private Framework framework;

        public EventFilter(Framework framework)
        {
            this.framework = framework;
        }

        public virtual Event Filter(Event e)
        {
            return e;
        }
    }
}
