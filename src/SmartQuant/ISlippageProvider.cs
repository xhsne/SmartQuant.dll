// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public interface ISlippageProvider
    {
        double Slippage { get; set; }
        double GetPrice(ExecutionReport report);
    }
}
