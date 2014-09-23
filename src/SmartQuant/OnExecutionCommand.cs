// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class OnExecutionCommand : Event
    {
        private ExecutionCommand command;

        public override byte TypeId
        {
            get
            {
                return EventType.OnExecutionCommand;
            }
        }

        public OnExecutionCommand(ExecutionCommand command)
        {
            this.command = command;
        }
    }
}
