// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnTransaction : Event
    {
        public Transaction Transaction { get; private set; }

        public Portfolio Portfolio { get; private set; }

        public override byte TypeId
        {
            get
            {
                return EventType.OnTransaction;
            }
        }

        public OnTransaction(Portfolio portfolio, Transaction transaction)
        {
            this.Portfolio = portfolio;
            this.Transaction = transaction;
        }

        public override string ToString()
        {
            return string.Format("OnTransaction {0}", this.Transaction.ToString());
        }
    }
}
