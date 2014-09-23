//
// Author: Alex Lee <lu.lee05@gmail.com>
//

namespace SmartQuant
{
    public class PerformanceProvider : Provider, IDataProvider, IExecutionProvider
    {
        public PerformanceProvider(Framework framework) : base(framework)
        {
        }

        public void Subscribe(Instrument instrument)
        {
            throw new System.NotImplementedException();
        }

        public void Subscribe(InstrumentList instrument)
        {
            throw new System.NotImplementedException();
        }

        public void Unsubscribe(Instrument instrument)
        {
            throw new System.NotImplementedException();
        }

        public void Unsubscribe(InstrumentList instrument)
        {
            throw new System.NotImplementedException();
        }

        public void Send(ExecutionCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
