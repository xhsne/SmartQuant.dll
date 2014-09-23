// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public interface IGroupListener
    {
        PermanentQueue<Event> Queue { get; }
        bool OnNewGroup(Group group);
        void OnNewGroupEvent(GroupEvent groupEvent);
        void OnNewGroupUpdate(GroupUpdate groupUpdate);
    }
}
