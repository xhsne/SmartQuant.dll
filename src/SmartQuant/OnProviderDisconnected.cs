// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnProviderDisconnected : Event
    {
        internal Provider Provider { get; private set; }

        public override byte TypeId
        {
            get
            {
                return EventType.OnProviderDisconnected;
            }
        }

        public OnProviderDisconnected(Provider provider)
        {
            this.Provider = provider;
        }
    }
}
