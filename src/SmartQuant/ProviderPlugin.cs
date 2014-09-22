// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.ComponentModel;
using System.Xml.Serialization;

namespace SmartQuant
{
    public class ProviderPlugin
    {
        [XmlElement("TypeName")]
        public string TypeName { get; set; }

        [XmlElement("X64")]
        public bool X64 { get; set; }

        public ProviderPlugin(string typeName, bool x64 = false)
        {
            this.TypeName = typeName;
            this.X64 = x64;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.TypeName, (this.X64 ? 1 : 0).ToString());
        }
    }
}
