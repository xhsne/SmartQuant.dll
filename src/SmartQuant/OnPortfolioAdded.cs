// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnPortfolioAdded : Event
    {
        public Portfolio Portfolio { get; private set; }

        public override byte  TypeId
        {
            get
            {
                return  EventType.OnPortfolioAdded;
            }
        }

        public OnPortfolioAdded(Portfolio portfolio)
        {
            this.Portfolio = portfolio;
        }
    }
}
