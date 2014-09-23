// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class DataFilter
    {
        private Framework framework;

        public DataFilter(Framework framework)
        {
            this.framework = framework;
        }

        public virtual DataObject Filter(DataObject obj)
        {
            return obj;
        }
    }
}
