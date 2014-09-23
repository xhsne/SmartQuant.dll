// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnExecutionReport : Event
    {
        private ExecutionReport report;

        public override byte TypeId
        {
            get
            {
                return EventType.OnExecutionReport;
            }
        }

        public OnExecutionReport(ExecutionReport report)
        {
            this.report = report;
        }
    }
}
