// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public interface ICommissionProvider
    {
        CommissionType Type { get; set; }
        double Commission { get; set; }
        double MinCommission { get; set; }
        double GetCommission(ExecutionReport report);
    }
}
