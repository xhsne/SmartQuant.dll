// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;
using System.Collections.Generic;

namespace SmartQuant
{
    public class DataServer : IDisposable
    {
        protected Framework framework;
        protected bool tapeMode;

        public bool TapeMode
        {
            get
            {
                return this.tapeMode;
            }
            set
            {
                this.tapeMode = value;
            }
        }

        public DataServer(Framework framework)
        {
            this.framework = framework;
            this.tapeMode = false;
        }

        public virtual void Open()
        {
        }

        public virtual void Close()
        {
        }

        public virtual void Flush()
        {
        }

        public virtual void Save(Instrument instrument, DataObject obj)
        {
        }

        public virtual DataSeries GetDataSeries(Instrument instrument, byte type)
        {
            return null;
        }

        public virtual DataSeries GetDataSeries(string name)
        {
            return null;
        }

        public virtual List<DataSeries> GetDataSeriesList(Instrument instrument = null, string pattern = null)
        {
            return null;
        }

        public virtual void DeleteDataSeries(Instrument instrument, byte type)
        {
        }

        public virtual void DeleteDataSeries(string name)
        {
        }

        public virtual DataSeries AddDataSeries(Instrument instrument, byte type)
        {
            return null;
        }

        public virtual DataSeries AddDataSeries(string name)
        {
            return null;
        }

        public virtual void Dispose()
        {
            this.Close();
        }
    }
}
