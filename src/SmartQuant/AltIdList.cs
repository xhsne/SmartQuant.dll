// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.Collections.Generic;
using System.Collections;

namespace SmartQuant
{
    public class AltIdList : IEnumerable<AltId>, IEnumerable
    {
        public AltIdList()
        {
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException(); 
            }
        }

        public AltId this[int i]
        {
            get
            {
                throw new NotImplementedException(); 
            }
        }

        public void Clear()
        {
        }

        public void Add(AltId id)
        {
        }

        public void Remove(AltId id)
        {
        }

        public AltId Get(byte providerId)
        {
            throw new NotImplementedException(); 
        }

        public IEnumerator<AltId> GetEnumerator()
        {
            throw new NotImplementedException(); 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException(); 
        }
    }
}

