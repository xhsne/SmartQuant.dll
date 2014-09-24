// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;

namespace SmartQuant
{
    public abstract class OrderServer : FrameworkServer
    {
        public abstract List<ExecutionMessage> Load();

        public abstract void Save(ExecutionMessage message);
    }
}
