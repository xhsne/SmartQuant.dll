// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class ProviderError : DataObject
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.ProviderError;
            }
        }

        public ProviderErrorType Type { get; set; }

        public byte ProviderId { get; set; }

        public int Id { get; set; }

        public int Code { get; set; }

        public string Text { get; set; }

        public ProviderError(DateTime dateTime, ProviderErrorType type, byte providerId, int id, int code, string text) : base(dateTime)
        {
            this.Type = type;
            this.ProviderId = providerId;
            this.Id = id;
            this.Code = code;
            this.Text = text;
        }

        public ProviderError(DateTime dateTime, ProviderErrorType type, byte providerId, string text) : this(dateTime, type, providerId, -1, -1, text)
        {
        }

        public ProviderError()
        {
        }

        public override string ToString()
        {
            return string.Format("id={0} type={1} code={2} text={3}", this.Id, this.Type, this.Code, this.Text);
        }
    }
}
