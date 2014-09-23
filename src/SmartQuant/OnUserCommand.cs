// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnUserCommand : Event
    {
        private string command;

        public override byte TypeId
        {
            get
            {
                return EventType.OnUserCommand;
            }
        }

        public OnUserCommand(string command)
        {
            this.command = command;
        }
    }
}