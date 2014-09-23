//
// Author: Alex Lee <lu.lee05@gmail.com>
//

using System;

namespace SmartQuant
{
    public class OnSimulatorProgress : DataObject
    {
        internal long count;
        internal int percent;

        public override byte TypeId
        {
            get
            {
                return DataObjectType.OnSimulatorProgress;
            }
        }

        public OnSimulatorProgress()
        {
            this.DateTime = DateTime.MinValue;
        }

        public OnSimulatorProgress(long count, int percent)
        {
            this.count = count;
            this.percent = percent;
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
