// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class Indicator : TimeSeries
    {
        protected ISeries input;
        protected bool calculate;

        public override int Count
        {
            get
            {
                this.Calculate();
                return base.Count;
            }
        }

        public override double First
        {
            get
            {
                this.Calculate();
                return base.First;
            }
        }

        public override double Last
        {
            get
            {
                this.Calculate();
                return base.Last;
            }
        }

        public override DateTime FirstDateTime
        {
            get
            {
                this.Calculate();
                return base.FirstDateTime;
            }
        }

        public override DateTime LastDateTime
        {
            get
            {
                this.Calculate();
                return base.LastDateTime;
            }
        }

        public override double this[int index]
        {
            get
            {
                this.Calculate();
                return base[index];
            }
            set
            {
                this.Calculate();
                base[index] = value;
            }
        }

        public override double this[int index, BarData barData]
        {
            get
            {
                this.Calculate();
                return base[index, barData];
            }
        }

        public Indicator(ISeries input)
        {
            this.input = input;
            this.input.Indicators.Add(this);
            this.calculate = true;
        }

        public void Attach()
        {
            this.input.Indicators.Add(this);
        }

        public void Detach()
        {
            this.input.Indicators.Remove(this);
        }

        public override int GetIndex(DateTime datetime, IndexOption option = IndexOption.Null)
        {
            this.Calculate();
            return base.GetIndex(datetime, option);
        }

        public override DateTime GetDateTime(int index)
        {
            this.Calculate();
            return base.GetDateTime(index);
        }

        public override double GetMin(DateTime dateTime1, DateTime dateTime2)
        {
            this.Calculate();
            return base.GetMin(dateTime1, dateTime2);
        }

        public override double GetMax(DateTime dateTime1, DateTime dateTime2)
        {
            this.Calculate();
            return base.GetMax(dateTime1, dateTime2);
        }

        protected virtual void Init()
        {
        }

        protected virtual void Calculate()
        {
            if (!this.calculate)
                return;
            this.calculate = false;
            Indicator indicator = this.input as Indicator;
            if (indicator != null)
                indicator.Calculate();
            for (int i = 0; i < this.input.Count; ++i)
                this.Calculate(i);
        }

        protected internal virtual void Calculate(int index)
        {
        }
    }
}
