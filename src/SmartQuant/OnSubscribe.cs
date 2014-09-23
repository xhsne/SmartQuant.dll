// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class OnSubscribe : Event
    {
        internal Instrument Instrument { get; private set; }
        internal InstrumentList Instruments { get; private set; }
        private DateTime dateTime1;
        private DateTime dateTime2;

        public override byte TypeId
        {
            get
            {
                return EventType.OnSubscribe;
            }
        }

        public OnSubscribe(Instrument instrument, DateTime dateTime1, DateTime dateTime2)
        {
            this.Instrument = instrument;
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
        }

        public OnSubscribe(InstrumentList instruments)
        {
            this.Instruments = instruments;
            this.dateTime1 = DateTime.MinValue;
            this.dateTime2 = DateTime.MaxValue;
        }

        public OnSubscribe(Instrument instrument) : this(instrument, DateTime.MinValue, DateTime.MaxValue)
        {
        }

        public override string ToString()
        {
            return string.Format("Subscribe {0} {1} - {2}", this.Instrument.Symbol, this.dateTime1, this.dateTime2);
        }
    }
}
