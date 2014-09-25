// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class EventQueue : IEventQueue
    {
        public byte Id { get; private set; }

        public byte Type { get; private set; }

        public int Size { get; private set; }

        public bool IsSynched { get; set; }

        public string Name { get; private set; }

        public byte Priority { get; private set; }

        public long Count
        {
            get { throw new NotImplementedException(); }
        }

        public long FullCount
        {
            get { throw new NotImplementedException(); }
        }

        public long EmptyCount
        {
            get { throw new NotImplementedException(); }
        }

        public EventQueue(byte id, byte type = EventQueueType.Master, byte priority = EventQueuePriority.Normal, int size = 100000)
        {
            this.Id = id;
            this.Type = type;
            this.Priority = priority;
            this.Size = size;
        }

        public Event Peek()
        {
            throw new NotImplementedException();
        }

        public DateTime PeekDateTime()
        {
            throw new NotImplementedException();
        }

        public Event Read()
        {
            throw new NotImplementedException();
        }

        public void Write(Event obj)
        {
            throw new NotImplementedException();
        }

        public Event Dequeue()
        {
            throw new NotImplementedException();
        }

        public void Enqueue(Event obj)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new NotImplementedException();
        }

        public bool IsFull()
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void ResetCounts()
        {
            throw new NotImplementedException();
        }
    }

}
