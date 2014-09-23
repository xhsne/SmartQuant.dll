// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class ReportItem
    {
        protected internal int id;
        protected internal string name;
        protected internal string description;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public ReportItem()
        {
        }

        protected virtual void OnBid(Bid bid)
        {
        }

        protected virtual void OnAsk(Ask Ask)
        {
        }

        protected virtual void OnTrade(Trade trade)
        {
        }

        protected virtual void OnBar(Bar bar)
        {
        }

        protected virtual void OnExecutionReport(ExecutionReport report)
        {
        }

        protected internal virtual void Clear()
        {
        }
    }
}

