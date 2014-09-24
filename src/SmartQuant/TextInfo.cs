// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class TextInfo : DataObject
    {
        public string Content { get; set; }

        public override byte TypeId
        {
            get
            {
                return DataObjectType.Text;
            }
        }

        public TextInfo(DateTime dateTime, string content) : base(dateTime)
        {
            this.Content = content;
        }

        public TextInfo(DateTime dateTime, object data) : this(dateTime, data.ToString())
        {
        }
    }
}
