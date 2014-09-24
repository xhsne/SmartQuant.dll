// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.Collections.Generic;

namespace SmartQuant
{
    public class DataFile
    {
        private Dictionary<string, ObjectKey> keys = new Dictionary<string, ObjectKey>();

        public byte CompressionMethod { set; get; }

        public byte CompressionLevel { set; get; }

        public Dictionary<string, ObjectKey> Keys
        {
            get
            {
                return this.keys;
            }
        }

        public DataFile(string name, StreamerManager streamerManager)
        {
        }

        ~DataFile()
        {
        }

        public void Dispose()
        {
        }

        protected internal virtual void WriteBuffer(byte[] buffer, long position, int length)
        {
        }
    }
}

