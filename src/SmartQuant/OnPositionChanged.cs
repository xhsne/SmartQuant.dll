// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnPositionChanged : Event
    {
        public Portfolio Portfolio { get; set; }
        public Position Position { get; set; }

        public override byte TypeId
        {
            get
            {
                return EventType.OnPositionChanged;
            }
        }

        public OnPositionChanged(Portfolio portfolio, Position position)
        {
            this.Portfolio = portfolio;
            this.Position = position;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.GetType().Name, this.Position);
        }
    }
}
