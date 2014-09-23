// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
	public class EventQueue : IEventQueue
	{
        public byte Id
        {
            get { throw new NotImplementedException(); }
        }

        public byte Type
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsSynched
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public byte Priority
        {
            get { throw new NotImplementedException(); }
        }

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
