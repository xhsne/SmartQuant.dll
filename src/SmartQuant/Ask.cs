// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class Ask : Tick
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.Ask;
            }
        }

        public Ask(DateTime dateTime, byte providerId, int instrument, double price, int size) : base(dateTime, providerId, instrument, price, size)
        {
        }

        public Ask(DateTime dateTime, DateTime exchangeDateTime, byte providerId, int instrument, double price, int size) : base(dateTime, exchangeDateTime, providerId, instrument, price, size)
        {
        }

        public Ask()
        {
        }

        public Ask(Ask ask) : base(ask)
        {
        }

        public override string ToString()
        {
            return string.Format("Ask {0} {1} {2} {3} {4}", this.DateTime, this.ProviderId, this.InstrumentId, this.Price, this.Size);
        }
    }
}
