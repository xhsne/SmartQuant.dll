// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class Trade : Tick
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.Trade;
            }
        }

        public Trade(DateTime dateTime, byte providerId, int instrumentId, double price, int size) : base(dateTime, providerId, instrumentId, price, size)
        {
        }

        public Trade(DateTime dateTime, DateTime exchangeDateTime, byte providerId, int instrumentId, double price, int size) : base(dateTime, providerId, instrumentId, price, size)
        {
        }

        public Trade()
        {
        }

        public Trade(Trade trade) : base(trade)
        {
        }

        public override string ToString()
        {
            return string.Format("Trade {0} {1} {2} {3} {4}", this.DateTime, this.ProviderId, this.InstrumentId, this.Price, this.Size);
        }
    }
}
