// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class Level2 : Tick
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.Level2;
            }
        }

        public Level2Side Side { get; set; }

        public Level2UpdateAction Action { get; set; }

        public int Position { get; set; }

        public Level2(DateTime dateTime, byte providerId, int instrumentId, double price, int size, Level2Side side, Level2UpdateAction action, int position) : base(dateTime, providerId, instrumentId, price, size)
        {
            this.Side = side;
            this.Action = action;
            this.Position = position;
        }

        public Level2()
        {
        }
    }
}
