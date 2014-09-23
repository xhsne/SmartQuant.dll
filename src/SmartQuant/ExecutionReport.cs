// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class ExecutionReport : ExecutionMessage
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.ExecutionReport;
            }
        }

        public byte CurrencyId { get; set; }

        public ExecType ExecType { get; set; }

        public OrderType OrdType { get; set; }

        public OrderSide Side { get; set; }

        public TimeInForce TimeInForce { get; set; }

        public OrderStatus OrdStatus { get; set; }

        public double LastPx { get; set; }

        public double AvgPx { get; set; }

        public double OrdQty { get; set; }

        public double CumQty { get; set; }

        public double LastQty { get; set; }

        public double LeavesQty { get; set; }

        public double Price { get; set; }

        public double StopPx { get; set; }

        public double Commission { get; set; }

        public string Text { get; set; }

        public ExecutionReport()
        {
        }

        public ExecutionReport(ExecutionReport report)
        {
            this.DateTime = report.DateTime;
            this.Instrument = report.Instrument;
            this.Order = report.Order;

            this.CurrencyId = report.CurrencyId;
            this.ExecType = report.ExecType;
            this.OrdType = report.OrdType;
            this.Side = report.Side;
            this.TimeInForce = report.TimeInForce;
            this.OrdStatus = report.OrdStatus;
            this.LastPx = report.LastPx;
            this.AvgPx = report.AvgPx;
            this.OrdQty = report.OrdQty;
            this.CumQty = report.CumQty;
            this.LastQty = report.LastQty;
            this.LeavesQty = report.LeavesQty;
            this.Price = report.Price;
            this.StopPx = report.StopPx;
            this.Commission = report.Commission;
            this.Text = report.Text;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", this.DateTime, this.Instrument.Symbol, this.ExecType, this.Side, this.AvgPx);
        }
    }
}
