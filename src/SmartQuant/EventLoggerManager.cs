// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;

namespace SmartQuant
{
    public class EventLoggerManager
    {
        private Dictionary<string, EventLogger> loggers = new Dictionary<string, EventLogger>();

        public void Add(EventLogger logger)
        {
            this.loggers[logger.Name] = logger;
        }

        public EventLogger GetLogger(string name)
        {
            return this.loggers[name];
        }
    }
}
