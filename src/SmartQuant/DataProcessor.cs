// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class DataProcessor
    {
        public bool EmitBar { get; set; }

        public bool EmitBarOpen { get; set; }

        public bool EmitBarOpenTrade { get; set; }

        public bool EmitBarHighTrade { get; set; }

        public bool EmitBarLowTrade { get; set; }

        public bool EmitBarCloseTrade { get; set; }

        public DataProcessor()
        {
            this.EmitBar = true;
            this.EmitBarOpen = true;
        }


        protected virtual DataObject OnData(DataObject obj)
        {
            throw new NotImplementedException();
        }

        protected void Emit(DataObject obj)
        {
            throw new NotImplementedException();
        }
    }
}

