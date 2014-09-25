// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
	public class EventServer
	{
        private Framework framework;
        private EventBus bus;

        public EventServer(Framework framework, EventBus bus)
        {
            this.framework = framework;
            this.bus = bus;
        }

        public void OnFrameworkCleared(Framework framework)
        {
            throw new System.NotImplementedException();
        }
	}

}
