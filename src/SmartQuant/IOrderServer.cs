// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

using System.Collections.Generic;

namespace SmartQuant
{
    public interface IOrderServer
    {
        List<Order> Load();
        void Save(List<Order> orders);
    }
}
