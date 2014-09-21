// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public enum OrderStatus : byte
    {
        NotSent,
        PendingNew,
        New,
        Rejected,
        PartiallyFilled,
        Filled,
        PendingCancel,
        Cancelled,
        Expired,
        PendingReplace,
        Replaced
    }
}
