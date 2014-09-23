//
// Author: Alex Lee <lu.lee05@gmail.com>
//

using System;
using System.Collections.Generic;

namespace SmartQuant
{
    public interface IDataSimulator : IDataProvider, IProvider
    {
        DateTime DateTime1 { get; set; }

        DateTime DateTime2 { get; set; }

        bool SubscribeBid { get; set; }

        bool SubscribeAsk { get; set; }

        bool SubscribeTrade { get; set; }

        bool SubscribeBar { get; set; }

        bool SubscribeLevelII { get; set; }

        bool SubscribeNews { get; set; }

        bool SubscribeFundamental { get; set; }

        bool SubscribeAll { set; }

        DataProcessor Processor { get; set; }

        List<IDataSeries> Series { get; set; }

        void Clear();
    }
}
