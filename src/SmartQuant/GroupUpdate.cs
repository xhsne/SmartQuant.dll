// Licensed under the Apache License, Version 2.0. 
// Copyright (c) Alex Lee. All rights reserved.

namespace SmartQuant
{
    public class GroupUpdate : DataObject
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.GroupUpdate;
            }
        }

        public int GroupId { get; private set; }

        public string FieldName { get; private set; }

        public GroupUpdateType UpdateType { get; private set; }

        public byte FieldType { get; private set; }

        public object Value { get; private set; }

        public object OldValue { get; private set; }

        public GroupUpdate(int groupId, string fieldName, byte fieldType, object value, object oldValue, GroupUpdateType updateType)
        {
            this.GroupId = groupId;
            this.FieldName = fieldName;
            this.FieldType = fieldType;
            this.Value = value;
            this.OldValue = oldValue;
            this.UpdateType = updateType;
        }
    }
}
