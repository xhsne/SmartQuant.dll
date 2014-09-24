// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;

namespace SmartQuant
{
    public class ProviderPropertyList
    {
        private Dictionary<string, string> properties  = new Dictionary<string, string>();

        public void SetValue(string name, string value)
        {
            this.properties[name] = value;
        }

        public string GetStringValue(string name, string defaultValue)
        {
            string s;
            return this.properties.TryGetValue(name, out s) ? s : defaultValue;
        }
    }
}
