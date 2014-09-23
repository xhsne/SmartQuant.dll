// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public interface IExecutionSimulator : IExecutionProvider
    {
        ICommissionProvider CommissionProvider { get; set; }
        ISlippageProvider SlippageProvider { get; set; }
        void OnBid(Bid bid);
        void OnAsk(Ask ask);
        void OnLevel2(Level2Snapshot snapshot);
        void OnLevel2(Level2Update update);
        void OnTrade(Trade trade);
        void OnBar(Bar bar);
        void Clear();
    }
}
