// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class Reminder : DataObject
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.Reminder;
            }
        }

        public ReminderCallback Callback { get; private set; }

        public object Data { set; get; }

        public Reminder(ReminderCallback callback, DateTime dateTime, object data) : base(dateTime)
        {
            this.Callback = callback;
            this.Data = data;
        }

        public void Execute()
        {
            this.Callback(this.DateTime, this.Data);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.GetType().Name, this.DateTime);
        }
    }
}
