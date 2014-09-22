// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class CurrencyConverter : ICurrencyConverter
    {
        private Framework framework;

        public CurrencyConverter(Framework framework)
        {
            this.framework = framework;
        }

        public virtual double Convert(double amount, byte fromCurrencyId, byte toCurrencyId)
        {
            return amount;
        }
    }
}
