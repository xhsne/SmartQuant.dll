// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;
using System;
using System.Reflection;

namespace SmartQuant
{
    public class StatisticsManager
    {
        private Framework framework;

        public PortfolioStatisticsItemList Statistics { get; internal set; }

        public StatisticsManager(Framework framework)
        {
            this.framework = framework;
            this.Statistics = new PortfolioStatisticsItemList();

            foreach (FieldInfo info in typeof(PortfolioStatisticsType).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (info.FieldType == typeof(int))
                {
                    Type t = Type.GetType(info.Name);
                    if (t != null)
                    {
                        var item = (PortfolioStatisticsItem)Activator.CreateInstance(t);
                        this.Add(item);
                    }
                }
            }
        }

        public void Add(PortfolioStatisticsItem item)
        {
            this.Statistics.Add(item);
        }

        public bool Contains(int type)
        {
            return this.Statistics.Contains(type);
        }

        public void Remove(int type)
        {
            this.Statistics.Remove(type);
        }

        public PortfolioStatisticsItem Get(int type)
        {
            return this.Statistics.GetByType(type);
        }

        public PortfolioStatisticsItem Clone(int type)
        {
            return (PortfolioStatisticsItem)Activator.CreateInstance(this.Get(type).GetType());
        }

        public List<PortfolioStatisticsItem> CloneAll()
        {
            var list = new List<PortfolioStatisticsItem>();
            foreach (var obj in this.Statistics)
            {
                var item = (PortfolioStatisticsItem)Activator.CreateInstance(obj.GetType());
                list.Add(item);
            }
            return list;
        }
    }
}
