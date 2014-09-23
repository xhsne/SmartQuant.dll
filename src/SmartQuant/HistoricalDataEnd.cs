//
// Author: Alex Lee <lu.lee05@gmail.com>
//

namespace SmartQuant
{
    public class HistoricalDataEnd : Event
    {
        public override byte TypeId
        {
            get
            {
                return EventType.HistoricalDataEnd;
            }
        }

        public string RequestId { get; set; }

        public RequestResult Result { get; set; }

        public string Text { get; set; }
    }
}
