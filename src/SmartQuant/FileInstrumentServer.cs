using System;

namespace SmartQuant
{
    public class FileInstrumentServer : InstrumentServer
    {
        public FileInstrumentServer(Framework framework, string fileName, string host = null) : base(framework)
        {
        }
    }
}

