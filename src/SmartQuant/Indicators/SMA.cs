// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using SmartQuant;
using System;
using System.ComponentModel;

namespace SmartQuant.Indicators
{
    [Serializable]
    public class SMA : Indicator
    {
        protected int length;
        protected BarData barData;

        [Description("")]
        [Category("Parameters")]
        public BarData BarData
        {
            get
            {
                return this.barData;
            }
            set
            {
                this.barData = value;
                this.Init();
            }
        }

        [Description("")]
        [Category("Parameters")]
        public int Length
        {
            get
            {
                return this.length;
            }
            set
            {
                this.length = value;
                this.Init();
            }
        }

        public SMA(ISeries input, int length, BarData barData = BarData.Close) : base(input)
        {
            this.length = length;
            this.barData = barData;
            this.Init();
        }

        protected override void Init()
        {
            this.name = string.Format("SMA ({0})", this.length);
            this.description = "Simple Moving Average";
            this.Clear();
            this.calculate = true;
        }

        protected internal override void Calculate(int index)
        {
            if (this.calculate)
            {
                this.Calculate();
            }
            else
            {
                if (index < this.length - 1)
                    return;
                double num = 0.0;
                if (index == this.length - 1)
                {
                    for (int i = index; i >= index - this.length + 1; --i)
                        num += this.input[i, this.barData] / (double)this.length;
                }
                else
                {
                    num = this[this.input.GetDateTime(index - 1), SearchOption.ExactFirst] + (this.input[index, this.barData] - this.input[index - this.length, this.barData]) / (double)this.length;
                }
                this.Add(this.input.GetDateTime(index), num);
            }
        }

        public static double Value(ISeries input, int index, int length, BarData barData = BarData.Close)
        {
            if (index < length - 1)
                return double.NaN;
            double num = 0.0;
            for (int i = index; i >= index - length + 1; --i)
                num += input[i, barData];
            return num / (double)length;
        }
    }
}
