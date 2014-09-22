// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SmartQuant
{
    [DataContract]
    public struct JsonProvider
    {
        [DataMember]
        public int ProviderId;

        [DataMember]
        public int InstanceId;

        [DataMember]
        public List<JsonProviderProperty> Properties;
    }
}
