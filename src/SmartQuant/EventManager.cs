// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class EventManager
    {
        private Framework framework;
        private EventBus bus;

        public EventManagerStatus Status { get; private set; }

        public EventFilter Filter { get; set; }

        public EventLogger Logger { get; set; }

        public BarFactory BarFactory { get; set; }

        public BarSliceFactory BarSliceFactory { get; set; }

        public long EventCount { get; private set; }

        public long DataEventCount { get; private set; }

        public EventDispatcher Dispatcher { get; set; }

        public EventManager(Framework framework, EventBus bus)
        {
            this.framework = framework;
            this.bus = bus;
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Pause()
        {
            throw new NotImplementedException();
        }

        public void Pause(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public void Resume()
        {
            throw new NotImplementedException();
        }

        public void Step(byte typeId = 0)
        {
            throw new NotImplementedException();
        }

        public void OnEvent(Event e)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
        }
    }
}
