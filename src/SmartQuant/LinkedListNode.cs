// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class LinkedListNode<T>
    {
        public T Data;
        public LinkedListNode<T> Next;

        public LinkedListNode(T data)
        {
            this.Data = data;
        }
    }
}
