// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public enum InstrumentType : byte
    {
        Stock,
        Future,
        Option,
        FutureOption,
        Bond,
        FX,
        Index,
        ETF,
        MultiLeg,
        Synthetic
    }
}
