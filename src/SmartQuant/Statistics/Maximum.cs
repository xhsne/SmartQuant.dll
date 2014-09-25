// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant.Statistics
{
    public abstract class Maximum : PortfolioStatisticsItem
    {
        protected int type;

        public Maximum(int type)
        {
            this.type = type;
        }

        protected internal override void OnInit()
        {
            this.Subscribe(this.type);
        }

        protected internal override void OnStatistics(PortfolioStatisticsItem statistics)
        {
            if (statistics.Type != this.type)
                return;
            this.longValue = Math.Max(this.longValue, statistics.longValue);
            this.shortValue = Math.Max(this.shortValue, statistics.shortValue);
            this.totalValue = Math.Max(this.totalValue, statistics.totalValue);
            this.longValues.Add(this.Clock.DateTime, this.longValue);
            this.shortValues.Add(this.Clock.DateTime, this.shortValue);
            this.totalValues.Add(this.Clock.DateTime, this.totalValue);
            this.Emit();
        }
    }
}
