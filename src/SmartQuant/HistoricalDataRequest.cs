// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class HistoricalDataRequest
    {
        public string RequestId { get; set; }

        public Instrument Instrument { get; set; }

        public DateTime DateTime1 { get; set; }

        public DateTime DateTime2 { get; set; }

        public byte DataType { get; set; }

        public BarType? BarType { get; set; }

        public long? BarSize { get; set; }

        public HistoricalDataRequest(Instrument instrument, DateTime dateTime1, DateTime dateTime2, byte dataType)
        {
            this.Instrument = instrument;
            this.DateTime1 = dateTime1;
            this.DateTime2 = dateTime2;
            this.DataType = dataType;
        }

        public HistoricalDataRequest()
        {
        }
    }
}
