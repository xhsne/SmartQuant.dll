// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnHistoricalData : Event
    {
        private HistoricalData data;

        public override byte TypeId
        {
            get
            {
                return EventType.OnHistoricalData;
            }
        }

        internal OnHistoricalData(HistoricalData data)
        {
            this.data = data;
        }
    }
}
