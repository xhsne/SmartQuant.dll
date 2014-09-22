// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartQuant
{
    [DataContract]
    public struct JsonProviderManagerSettings
    {
        [DataMember]
        public List<JsonProvider> Providers;
    }
}
