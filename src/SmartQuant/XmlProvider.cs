// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;
using System.Xml.Serialization;

namespace SmartQuant
{
    public struct XmlProvider
    {
        [XmlElement("id")]
        public int ProviderId;

        [XmlElement("instance")]
        public int InstanceId;

        [XmlArrayItem("property")]
        [XmlArray("properties")]
        public List<XmlProviderProperty> Properties;
    }
}
