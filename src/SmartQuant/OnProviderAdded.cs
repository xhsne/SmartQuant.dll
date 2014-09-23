// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnProviderAdded : Event
    {
        internal IProvider Provider { get; private set; }

        public override byte TypeId
        {
            get
            {
                return EventType.OnProviderAdded;
            }
        }

        public OnProviderAdded(IProvider provider)
        {
            this.Provider = provider;
        }
    }
}
