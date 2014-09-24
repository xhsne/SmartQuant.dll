// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.Collections.Generic;

namespace SmartQuant
{
    public class Bar : DataObject
    {
        internal IdArray<double> fields;

        private static Dictionary<string, byte> mapping;

        public override byte TypeId
        {
            get
            {
                return DataObjectType.Bar;
            }
        }

        public BarType Type { get; set; }

        public DateTime CloseDateTime
        {
            get
            {
                return this.DateTime;
            }
        }

        public DateTime OpenDateTime { get; internal set; }

        public TimeSpan Duration
        {
            get
            {
                return this.CloseDateTime - this.OpenDateTime;
            }
        }

        public int InstrumentId { get; set; }

        public BarStatus Status { get; set; }

        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public long Volume { get; set; }

        public long OpenInt { get; set; }

        public long N { get; set; }

        public long Size { get; set; }

        public double Mean { get; set; }

        public double Variance { get; set; }

        public double StdDev
        {
            get
            {
                return Math.Sqrt(this.Variance);
            }
        }

        public double Range
        {
            get
            {
                return this.High - this.Low;
            }
        }

        public double Median
        {
            get
            {
                return (this.High + this.Low) / 2.0;
            }
        }

        public double Typical
        {
            get
            {
                return (this.High + this.Low + this.Close) / 3.0;
            }
        }

        public double Weighted
        {
            get
            {
                return (this.High + this.Low + 2.0 * this.Close) / 4.0;
            }
        }

        public double Average
        {
            get
            {
                return (this.Open + this.High + this.Low + this.Close) / 4.0;
            }
        }

        public double this[byte index]
        {
            get
            {
                return this.fields[index];
            }
            set
            {
                if (this.fields == null)
                    this.fields = new IdArray<double>(16);
                this.fields[index] = value;
            }
        }

        public double this[string name]
        {
            get
            {
                return this.fields[Bar.mapping[name]];
            }
            set
            {
                this[Bar.mapping[name]] = value;
            }
        }

        static Bar()
        {
            mapping = new Dictionary<string, byte>();
            foreach (string field in Enum.GetNames(typeof(BarData)))
            {
                byte n = (byte)Enum.Parse(typeof(BarData), field);
                AddField(field, n);
            }  
        }

        public Bar(DateTime openDateTime, DateTime closeDateTime, int instrumentId, BarType type, long size, double open = 0.0, double high = 0.0, double low = 0.0, double close = 0.0, long volume = 0, long openInt = 0) : base(closeDateTime)
        {
            this.OpenDateTime = openDateTime;
            this.InstrumentId = instrumentId;
            this.Type = type;
            this.Size = size;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
            this.Volume = volume;
            this.OpenInt = openInt;
            this.Status = openDateTime == closeDateTime ? BarStatus.Open : BarStatus.Close;
        }

        public Bar()
        {
            this.Type = BarType.Time;
            this.OpenDateTime = DateTime.MinValue;
            this.Close = double.NaN;
        }

        public Bar(Bar bar) : base(bar)
        {
            this.InstrumentId = bar.InstrumentId;
            this.Type = bar.Type;
            this.Size = bar.Size;
            this.OpenDateTime = bar.OpenDateTime;
            this.Open = bar.Open;
            this.High = bar.High;
            this.Low = bar.Low;
            this.Close = bar.Close;
            this.Volume = bar.Volume;
            this.OpenInt = bar.OpenInt;
        }

        public static void AddField(string name, byte index)
        {
            mapping.Add(name, index);
        }

        public override string ToString()
        {
            return string.Format("Bar [{0} - {1}] Instrument={2} Type={3} Size={4} Open={5} High={6} Low={7} Close={8} Volume={9}", this.OpenDateTime, this.DateTime, this.InstrumentId, this.Type, this.Size, this.Open, this.High, this.Low, this.Close, this.Volume);
        }
    }
}
