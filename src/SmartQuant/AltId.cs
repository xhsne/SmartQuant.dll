// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class AltId
    {
        public byte ProviderId { get; set; }

        public string Symbol { get; set; }

        public string Exchange { get; set; }

        public AltId()
        {
        }

        public AltId(byte providerId, string symbol, string exchange)
        {
            this.ProviderId = providerId;
            this.Symbol = symbol;
            this.Exchange = exchange;
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1}@{2}", this.ProviderId, this.Symbol, this.Exchange);
        }
    }
}
