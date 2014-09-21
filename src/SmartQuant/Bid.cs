// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class Bid : Tick
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.Bid;
            }
        }

        public Bid(DateTime dateTime, byte providerId, int instrumentId, double price, int size) : base(dateTime, providerId, instrumentId, price, size)
        {
        }

        public Bid(DateTime dateTime, DateTime exchangeDateTime, byte providerId, int instrumentId, double price, int size) : base(dateTime, exchangeDateTime, providerId, instrumentId, price, size)
        {
        }

        public Bid()
        {
        }

        public Bid(Bid bid) : base(bid)
        {
        }

        public override string ToString()
        {
            return string.Format("Bid {0} {1} {2} {3} {4}", this.DateTime, this.ProviderId, this.InstrumentId, this.Price, this.Size);
        }
    }
}
