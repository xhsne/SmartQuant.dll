// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnUnsubscribe : Event
    {
        internal InstrumentList Instruments { get; private set; }

        internal Instrument Instrument { get; private set; }

        public override byte TypeId
        {
            get
            {
                return EventType.OnUnsubscribe;
            }
        }

        public OnUnsubscribe(InstrumentList instruments)
        {
            this.Instruments = instruments;
        }

        public OnUnsubscribe(Instrument instrument)
        {
            this.Instrument = instrument;
        }
    }
}
