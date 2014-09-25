// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
	public class EventPipe
	{
        private Framework framework;

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public EventPipe(Framework framework)
        {
            this.framework = framework;
        }

        public void Add(IEventQueue queue)
        {
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public Event Read()
        {
            throw new NotImplementedException();
        }

        public Event Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
        }
	}
}
