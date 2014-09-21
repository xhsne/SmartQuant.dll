//
// Author: Alex Lee <lu.lee05@gmail.com>
//

using System;

namespace SmartQuant
{
    public class DataObject : Event
    {
        public override byte TypeId
        {
            get
            {
                return DataObjectType.DataObject;
            }
        }

        public DataObject()
        {
        }

        public DataObject(DateTime dateTime)
        {
            this.DateTime = dateTime;
        }

        public DataObject(DataObject obj)
        {
            this.DateTime = obj.DateTime;
        }
    }
}