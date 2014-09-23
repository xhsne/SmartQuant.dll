// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnFill : Event
    {
        public override byte TypeId
        {
            get
            {
                return EventType.OnFill;
            }
        }
            
        public Fill Fill { get; private set; }

        public Portfolio Portfolio { get; private set; }

        public OnFill(Portfolio portfolio, Fill fill)
        {
            this.Portfolio = portfolio;
            this.Fill = fill;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.GetType().Name + this.Fill.ToString());
        }
    }
}
