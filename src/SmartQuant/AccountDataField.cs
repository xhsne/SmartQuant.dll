// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class AccountDataField
    {
        public const string SYMBOL = "Symbol";
        public const string EXCHANGE = "Exchange";
        public const string SECURITY_TYPE = "SecurityType";
        public const string CURRENCY = "Currency";
        public const string MATURITY = "Maturity";
        public const string PUT_OR_CALL = "PutOrCall";
        public const string STRIKE = "Strike";
        public const string QTY = "Qty";
        public const string LONG_QTY = "LongQty";
        public const string SHORT_QTY = "ShortQty";
        public const string ORDER_ID = "OrderID";
        public const string ORDER_TYPE = "OrderType";
        public const string ORDER_SIDE = "OrderSide";
        public const string ORDER_STATUS = "OrderStatus";
        public const string PRICE = "Price";
        public const string STOP_PX = "StopPx";

        public string Name { get; private set; }

        public string Currency { get; private set; }

        public object Value { get; private set; }

        public AccountDataField(string name, string currency, object value)
        {
            this.Name = name;
            this.Currency = currency;
            this.Value = value;
        }

        public AccountDataField(string name, object value) : this(name, string.Empty, value)
        {
        }
    }
}
