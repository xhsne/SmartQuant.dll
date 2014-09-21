// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class Tick : DataObject
    {
        public byte ProviderId { get; set; }

        public int InstrumentId { get; set; }

        public double Price { get; set; }

        public int Size { get; set; }

        public DateTime ExchangeDateTime { get; set; }

        public Tick()
        {
        }

        public Tick(Tick tick)
            : base(tick)
        {
            this.ProviderId = tick.ProviderId;
            this.InstrumentId = tick.InstrumentId;
            this.Price = tick.Price;
            this.Size = tick.Size;
        }

        public Tick(DateTime dateTime, byte providerId, int instrumentId, double price, int size)
            : this(dateTime, default(DateTime), providerId, instrumentId, price, size)
        {
        }

        public Tick(DateTime dateTime, DateTime exchangeDateTime, byte providerId, int instrumentId, double price, int size)
            : base(dateTime)
        {
            this.ExchangeDateTime = exchangeDateTime;
            this.ProviderId = providerId;
            this.InstrumentId = instrumentId;
            this.Price = price;
            this.Size = size;
        }

        public override string ToString()
        {
            return string.Format("Tick {0} {1} {2} {3} {4}", this.DateTime, this.ProviderId, this.InstrumentId, this.Price, this.Size);
        }
    }
}