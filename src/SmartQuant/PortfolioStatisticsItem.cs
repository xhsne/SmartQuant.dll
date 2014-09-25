// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class PortfolioStatisticsItem
    {
        protected internal double totalValue;
        protected internal double longValue;
        protected internal double shortValue;
        protected internal TimeSeries totalValues;
        protected internal TimeSeries longValues;
        protected internal TimeSeries shortValues;
        protected internal Portfolio portfolio;
        protected internal PortfolioStatistics statistics;

        public virtual int Type
        {
            get
            {
                return 0;
            }
        }

        public virtual string Name
        {
            get
            {
                return "Unknown";
            }
        }

        public virtual string Format
        {
            get
            {
                return "F2";
            }
        }

        public virtual string Description
        {
            get
            {
                return "Unknown";
            }
        }

        public virtual string Category
        {
            get
            {
                return "Unknown";
            }
        }

        public virtual bool Show
        {
            get
            {
                return true;
            }
        }

        public double TotalValue
        {
            get
            {
                return this.totalValue;
            }
        }

        public double LongValue
        {
            get
            {
                return this.longValue;
            }
        }

        public double ShortValue
        {
            get
            {
                return this.shortValue;
            }
        }

        public TimeSeries TotalValues
        {
            get
            {
                return this.totalValues;
            }
        }

        public TimeSeries LongValues
        {
            get
            {
                return this.longValues;
            }
        }

        public TimeSeries ShortValues
        {
            get
            {
                return this.shortValues;
            }
        }

        public Clock Clock
        {
            get
            {
                throw new NotImplementedException();
            }
        }
            
        public PortfolioStatisticsItem()
        {
            throw new NotImplementedException();
        }

        public void Subscribe(int itemType)
        {
            throw new NotImplementedException();
        }

        public void Unsubscribe(int itemType)
        {
            throw new NotImplementedException();
        }

        protected internal void Emit()
        {
            throw new NotImplementedException();
        }

        protected internal virtual void OnInit()
        {
        }

        protected internal virtual void OnEquity(double equity)
        {
        }

        protected internal virtual void OnFill(Fill fill)
        {
        }

        protected internal virtual void OnTransaction(Transaction transaction)
        {
        }

        protected internal virtual void OnPositionOpened(Position position)
        {
        }

        protected internal virtual void OnPositionClosed(Position position)
        {
        }

        protected internal virtual void OnPositionChanged(Position position)
        {
        }

        protected internal virtual void OnRoundTrip(TradeInfo trade)
        {
        }

        protected internal virtual void OnStatistics(PortfolioStatisticsItem statistics)
        {
        }

        protected internal virtual void OnStatistics(Portfolio portfolio, PortfolioStatisticsItem statistics)
        {
        }

        protected internal virtual void OnClear()
        {
        }
    }
}
