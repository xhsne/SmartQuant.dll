// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class IdArray<T>
    {
        private T[] array;
        private int size;
        private int reserved;

        public int Size
        {
            get
            {
                return this.size;
            }
        }

        public T this[int id]
        {
            get
            {
                if (id >= this.size)
                    this.Resize(id);
                return this.array[id];
            }
            set
            {
                if (id >= this.size)
                    this.Resize(id);
                this.array[id] = value;
            }
        }

        public IdArray(int size = 1024)
        {
            this.size = size;
            this.reserved = size;
            this.array = new T[size];
            this.Clear();
        }

        public void Clear()
        {
            for (int i = 0; i < this.size; ++i)
                this.array[i] = default(T);
        }

        public void Add(int id, T value)
        {
            if (id >= this.size)
                this.Resize(id);
            this.array[id] = value;
        }

        public void Remove(int id)
        {
            if (id >= this.size)
                this.Resize(id);
            this.array[id] = default(T);
        }

        private void Resize(int id)
        {
            Console.WriteLine("IdArray::Resize index = " + id);
            int length = id + this.reserved;
            T[] newArray = new T[length];
            for (int i = 0; i < this.size; ++i)
                newArray[i] = this.array[i];
            for (int i = this.size; i < length; ++i)
                newArray[i] = default(T);
            this.array = newArray;
            this.size = length;
        }

        public void CopyTo(IdArray<object> array)
        {
            array.Clear();
            for (int i = 0; i < this.size; ++i)
                array[i] = this[i];
        }
    }
}
