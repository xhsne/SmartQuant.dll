using System;

namespace SmartQuant
{
    public class EventDispatcher
    {
        protected internal Framework framework;

        public event FrameworkEventHandler FrameworkCleared;

        public event InstrumentEventHandler InstrumentAdded;

        public event InstrumentEventHandler InstrumentDeleted;

        public event InstrumentDefinitionEventHandler InstrumentDefinition;

        public event InstrumentDefinitionEndEventHandler InstrumentDefinitionEnd;

        public event ProviderEventHandler ProviderAdded;

        public event ProviderEventHandler ProviderRemoved;

        public event ProviderEventHandler ProviderStatusChanged;

        public event ProviderEventHandler ProviderConnected;

        public event ProviderEventHandler ProviderDisconnected;

        public event ExecutionCommandEventHandler ExecutionCommand;

        public event ExecutionReportEventHandler ExecutionReport;

        public event OrderManagerClearedEventHandler OrderManagerCleared;

        public event FillEventHandler Fill;

        public event TransactionEventHandler Transaction;

        public event BarEventHandler Bar;

        public event BidEventHandler Bid;

        public event AskEventHandler Ask;

        public event TradeEventHandler Trade;

        public event ProviderErrorEventHandler ProviderError;

        public event HistoricalDataEventHandler HistoricalData;

        public event HistoricalDataEndEventHandler HistoricalDataEnd;

        public event PortfolioEventHandler PortfolioAdded;

        public event PortfolioEventHandler PortfolioDeleted;

        public event PositionEventHandler PositionOpened;

        public event PositionEventHandler PositionChanged;

        public event PositionEventHandler PositionClosed;

        public event PortfolioEventHandler PortfolioParentChanged;

        public event GroupEventHandler NewGroup;

        public event GroupEventEventHandler NewGroupEvent;

        public event GroupUpdateEventHandler NewGroupUpdate;

        public event SimulatorProgressEventHandler SimulatorProgress;

        public event EventHandler SimulatorStop;

        public event AccountDataEventHandler AccountData;

        public event EventHandler EventManagerStarted;

        public event EventHandler EventManagerStopped;

        public event EventHandler EventManagerPaused;

        public event EventHandler EventManagerResumed;

        public event EventHandler EventManagerStep;

        public EventDispatcher(Framework framework)
        {
            this.framework = framework;
        }

        public void OnEvent(Event e)
        {
            throw new NotImplementedException();
        }
    }
}

