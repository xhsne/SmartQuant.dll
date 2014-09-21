// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public interface IDataProvider : IProvider
    {
        void Subscribe(Instrument instrument);
        void Subscribe(InstrumentList instrument);
        void Unsubscribe(Instrument instrument);
        void Unsubscribe(InstrumentList instrument);
    }
}
