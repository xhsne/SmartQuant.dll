// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnEventManagerPaused : Event
    {
        public override byte TypeId
        {
            get
            {
                return  EventType.OnEventManagerPaused;
            }
        }
    }
}
