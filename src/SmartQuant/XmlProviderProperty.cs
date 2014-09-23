// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Xml.Serialization;

namespace SmartQuant
{
    public struct XmlProviderProperty
    {
        [XmlAttribute("name")]
        public string Name;

        [XmlText]
        public string Value;
    }
}
