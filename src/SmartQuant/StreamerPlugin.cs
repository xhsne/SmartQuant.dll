// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Xml.Serialization;

namespace SmartQuant
{
    public class StreamerPlugin
    {
        [XmlElement("TypeName")]
        public string TypeName { get; set; }

        public StreamerPlugin(string typeName)
        {
            this.TypeName = typeName;
        }

        public override string ToString()
        {
            return this.TypeName;
        }
    }
}
