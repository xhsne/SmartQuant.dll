// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.Collections.Generic;

namespace SmartQuant
{
    public interface ISeries
    {
        string Name { get; }
        string Description { get; }
        int Count { get; }
        List<Indicator> Indicators { get; }
        double First { get; }
        double Last { get; }
        DateTime FirstDateTime { get; }
        DateTime LastDateTime { get; }
        double this[int index] { get; }
        double this[int index, BarData barData] { get; }
        int GetIndex(DateTime dateTime, IndexOption option = IndexOption.Null);
        DateTime GetDateTime(int index);
        double GetMin(DateTime dateTime1, DateTime dateTime2);
        double GetMin(int index1, int index2, BarData barData);
        double GetMax(DateTime dateTime1, DateTime dateTime2);
        double GetMax(int index1, int index2, BarData barData);
    }
}
