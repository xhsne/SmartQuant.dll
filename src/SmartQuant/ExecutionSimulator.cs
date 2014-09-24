
using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace SmartQuant
{
    public class ExecutionSimulator : IExecutionSimulator
	{
        public ExecutionSimulator(Framework framework)
        {
            throw new NotImplementedException();
        }

        public ICommissionProvider CommissionProvider
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

        public ISlippageProvider SlippageProvider
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

        public void OnBid(Bid bid)
        {
            throw new NotImplementedException();
        }

        public void OnAsk(Ask ask)
        {
            throw new NotImplementedException();
        }

        public void OnLevel2(Level2Snapshot snapshot)
        {
            throw new NotImplementedException();
        }

        public void OnLevel2(Level2Update update)
        {
            throw new NotImplementedException();
        }

        public void OnTrade(Trade trade)
        {
            throw new NotImplementedException();
        }

        public void OnBar(Bar bar)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void Send(ExecutionCommand command)
        {
            throw new NotImplementedException();
        }

        public ProviderStatus Status
        {
            get { throw new NotImplementedException(); }
        }

        public byte Id
        {
            get { throw new NotImplementedException(); }
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }
    }

}
