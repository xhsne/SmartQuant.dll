using System;

namespace SmartQuant
{
	public class Fill
	{
        public DateTime DateTime { get; set; }

        public double CashFlow { get; set; }

        public byte CurrencyId { get; set; }

        public string Text { get; set; }
    }
}

