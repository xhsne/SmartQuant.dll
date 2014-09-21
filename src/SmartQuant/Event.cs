//
// Author: Alex Lee <lu.lee05@gmail.com>
//

using System;

namespace SmartQuant
{
    public class Event
    {
        public DateTime DateTime { get; set; }

        public virtual byte TypeId
        {
            get
            {
                return EventType.Event;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.DateTime, this.GetType());
        }
    }
}
