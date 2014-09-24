// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class Clock
    {
        public Clock(Framework framework, ClockMode mode = ClockMode.Simulation, bool isStandalone = false) 
        {
            this.Mode = mode;
            throw new System.NotImplementedException();
        }

        public ClockMode Mode { get; set; }

        public ClockResolution Resolution { get; set; }

        public long Ticks { get {  throw new System.NotImplementedException(); } }

        public void AddReminder(ReminderCallback callback, DateTime dateTime, object data = null)
        {
            this.AddReminder(new Reminder(callback, dateTime, data));
        }

        public void AddReminder(Reminder reminder)
        {
        }

        public void RemoveReminder(ReminderCallback callback, DateTime dateTime)
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public string GetModeAsString()
        {
            switch (this.Mode)
            {
                case ClockMode.Realtime:
                    return "Realtime";
                case ClockMode.Simulation:
                    return "Simulation";
                default:
                    return "Undefined";
            }
        }
    }

}
