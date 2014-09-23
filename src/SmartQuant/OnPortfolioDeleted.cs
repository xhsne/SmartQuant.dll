// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnPortfolioDeleted : Event
    {
        public Portfolio Portfolio { get; private set; }

        public override byte TypeId
        {
            get
            {
                return EventType.OnPortfolioDeleted;
            }
        }

        public OnPortfolioDeleted(Portfolio portfolio)
        {
            this.Portfolio = portfolio;
        }
    }
}
