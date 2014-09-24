// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.Collections.Generic;

namespace SmartQuant
{
    public class DataSeries : IDataSeries
    {
        public long Count
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime DateTime1
        {
            get { throw new NotImplementedException(); }
        }

        public DateTime DateTime2
        {
            get { throw new NotImplementedException(); }
        }

        public DataObject this [long index]
        {
            get { throw new NotImplementedException(); }
        }

        public DataSeries()
        {
        }

        public DataSeries(string name)
        {
        }

        public long GetIndex(DateTime dateTime, SearchOption option = SearchOption.Prev)
        {
            throw new NotImplementedException();
        }

        public void Update(long index, DataObject obj)
        {
            throw new NotImplementedException();
        }

        public void Add(DataObject obj)
        {
            throw new NotImplementedException();
        }

        public DataObject Get(long index)
        {
            throw new NotImplementedException();
        }

        public void Remove(long index)
        {
            throw new NotImplementedException();
        }
            
        public DataObject Get(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Dump()
        {
            throw new NotImplementedException();
        }
    }
}
