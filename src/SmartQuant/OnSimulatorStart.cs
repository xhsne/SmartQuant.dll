//
// Author: Alex Lee <lu.lee05@gmail.com>
//

using System;

namespace SmartQuant
{
    public class OnSimulatorStart : DataObject
    {
        private DateTime dateTime1;
        private DateTime dateTime2;
        private long count;

        public override byte TypeId
        {
            get
            {
                return DataObjectType.OnSimulatorStart;
            }
        }

        public OnSimulatorStart()
        {
        }

        public OnSimulatorStart(DateTime dateTime1, DateTime dateTime2, long count)
        {
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
            this.count = count;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
