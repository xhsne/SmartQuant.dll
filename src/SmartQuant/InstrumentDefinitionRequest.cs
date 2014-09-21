// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class InstrumentDefinitionRequest
    {
        public string Id { get; set; }
        public InstrumentType? FilterType { get; set; }
        public string FilterSymbol { get; set; }
        public string FilterExchange { get; set; }
    }
}
