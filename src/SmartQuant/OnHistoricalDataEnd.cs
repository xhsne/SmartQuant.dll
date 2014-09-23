// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnHistoricalDataEnd : Event
    {
        private HistoricalDataEnd end;

        public override byte TypeId
        {
            get
            {
                return EventType.OnHistoricalDataEnd;
            }
        }

        internal OnHistoricalDataEnd(HistoricalDataEnd end)
        {
            this.end = end;
        }
    }
}
