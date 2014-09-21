// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public interface ICurrencyConverter
    {
        double Convert(double amount, byte fromCurrencyId, byte toCurrencyId);
    }
}
