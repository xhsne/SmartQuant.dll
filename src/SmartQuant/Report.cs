// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;

namespace SmartQuant
{
    public class Report
    {
        private List<ReportItem> reports = new List<ReportItem>();

        public void Add(ReportItem item)
        {
            this.reports.Add(item);
        }

        public void Clear()
        {
            foreach (ReportItem report in this.reports)
                report.Clear();
            this.reports.Clear();
        }
    }
}
