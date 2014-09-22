// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Runtime.Serialization;

namespace SmartQuant
{
    [DataContract]
    public struct JsonProviderProperty
    {
        [DataMember]
        public string Name;

        [DataMember]
        public string Value;
    }
}
