// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class EventBus
    {
        public EventBus(Framework framework, EventBusMode mode = EventBusMode.Simulation)
        {
            throw new System.NotImplementedException();
        }

        public EventBusMode Mode { get; set; }

        public EventPipe DataPipe { get; private set; }

        public EventPipe ExecutionPipe { get; private set; }

        public EventPipe HistoricalPipe  { get; private set; }

        public EventPipe ServicePipe  { get; private set; }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }
    }

}
