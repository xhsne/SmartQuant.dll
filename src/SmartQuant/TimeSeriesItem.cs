// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class TimeSeriesItem : DataObject
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.TimeSeriesItem;
            }
        }

        public double Value { get; internal set; }

        public TimeSeriesItem(DateTime dateTime, double value)
        {
            this.DateTime = dateTime;
            this.Value = value;
        }

        public TimeSeriesItem(TimeSeriesItem item) : this(item.DateTime, item.Value)
        {
        }

        public TimeSeriesItem()
        {
        }
    }
}
