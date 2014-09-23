// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class Quote : DataObject
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.Quote;
            }
        }

        public Bid Bid { get; private set; }

        public Ask Ask { get; private set; }

        public Quote(Bid bid, Ask ask)
        {
            this.Bid = bid;
            this.Ask = ask;
            this.DateTime = bid.DateTime > ask.DateTime ? bid.DateTime : ask.DateTime;
        }

        public Quote(DateTime dateTime, byte providerId, int instrumentId, double bidPrice, int bidSize, double askPrice, int askSize) : this(new Bid(dateTime, providerId, instrumentId, bidPrice, bidSize), new Ask(dateTime, providerId, instrumentId, askPrice, askSize))
        {
        }
    }
}
