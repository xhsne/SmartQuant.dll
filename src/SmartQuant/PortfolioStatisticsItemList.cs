// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;
using System.Collections;
using System;

namespace SmartQuant
{
    public class PortfolioStatisticsItemList : IEnumerable<PortfolioStatisticsItem>, IEnumerable
	{
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PortfolioStatisticsItem this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public PortfolioStatisticsItemList()
        {
            throw new NotImplementedException();
        }

        public bool Contains(int type)
        {
            throw new NotImplementedException();
        }

        public void Add(PortfolioStatisticsItem item)
        {
            throw new NotImplementedException();
        }

        public void Remove(int type)
        {
            throw new NotImplementedException();
        }

        public PortfolioStatisticsItem GetByType(int type)
        {
            throw new NotImplementedException();
        }

        public PortfolioStatisticsItem GetByIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<PortfolioStatisticsItem> GetEnumerator()
        {
            throw new NotImplementedException();        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
	}

}
