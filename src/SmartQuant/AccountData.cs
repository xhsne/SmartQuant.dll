// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System;

namespace SmartQuant
{
    public class AccountData : DataObject
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.AccountData;
            }
        }

        public AccountDataType Type { get; private set; }

        public string Account { get; private set; }

        public byte ProviderId { get; private set; }

        public byte Route { get; private set; }

        public AccountDataFieldList Fields { get; private set; }

        public AccountData(DateTime datetime, AccountDataType type, string account, byte providerId, byte route) : base(datetime)
        {
            this.Type = type;
            this.Account = account;
            this.ProviderId = providerId;
            this.Route = route;
            this.Fields = new AccountDataFieldList();
        }
    }
}
