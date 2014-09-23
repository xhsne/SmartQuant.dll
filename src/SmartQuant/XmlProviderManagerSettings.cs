// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;
using System.Xml.Serialization;

namespace SmartQuant
{
    [XmlRoot("settings")]
    public struct XmlProviderManagerSettings
    {
        [XmlArrayItem("provider")]
        [XmlArray("providers")]
        public List<XmlProvider> Providers;
    }
}
