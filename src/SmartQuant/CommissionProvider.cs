// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class CommissionProvider : ICommissionProvider
    {
        public double Commission { get; set; }
        public CommissionType Type { get; set; }
        public double MinCommission { get; set; }

        public virtual double GetCommission(ExecutionReport report)
        {
            double val;
            switch (this.Type)
            {
                case CommissionType.PerShare:
                    val = this.Commission * report.CumQty;
                    break;
                case CommissionType.Percent:
                    val = this.Commission * report.CumQty * report.AvgPx;
                    break;
                case CommissionType.Absolute:
                    val = this.Commission;
                    break;
                default:
                    throw new NotSupportedException(string.Format("Unknown commission type {0}", this.Type));
            }
            return Math.Max(val, this.MinCommission);
        }
    }
}
