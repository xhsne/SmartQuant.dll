//
// Author: Alex Lee <lu.lee05@gmail.com>
//

namespace SmartQuant
{
    public class OnPositionOpened : Event
    {
        public Portfolio Portfolio { get; set; }
        public Position Position { get; set; }

        public override byte TypeId
        {
            get
            {
                return EventType.OnPositionOpened;
            }
        }

        public OnPositionOpened(Portfolio portfolio, Position position)
        {
            this.Portfolio = portfolio;
            this.Position = position;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.GetType().Name, this.Position);
        }
    }
}
