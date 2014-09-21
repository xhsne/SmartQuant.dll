// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public interface IDataSeries
    {
        long Count { get; }

        string Name { get; }

        DateTime DateTime1 { get; }

        DateTime DateTime2 { get; }

        DataObject this [long index] { get; }

        long GetIndex(DateTime dateTime, SearchOption option = SearchOption.Prev);
    }
}

