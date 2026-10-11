namespace EconomicTrendsPolLESSIRE.Contracts.Hubs
{
    public static class MarketHubMethods
    {
        public const string HubPath = "marketDataHub";

        public const string AuthorizedGroup = "market-data-authorized";

        public static class ToClient
        {
            public const string CandleUpdated = "CandleUpdated";
            public const string InstrumentUpdated = "InstrumentUpdated";

            public const string InstrumentArchived = "InstrumentArchived";

            public const string MarketDataRefreshed = "MarketDataRefreshed";
            public const string MarketCandleArchived = "MarketCandleArchived";
            public const string MarketCandleUpdated = "MarketCandleUpdated";
            public const string MarketQuoteArchived = "MarketQuoteArchived";
            public const string MarketQuoteUpdated = "MarketQuoteUpdated";
            public const string MarketSnapshotArchived = "MarketSnapshotArchived";
            public const string MarketSnapshotUpdated = "MarketSnapshotUpdated";
            public const string MarketTradeArchived = "MarketTradeArchived";
            public const string MarketTradeUpdated = "MarketTradeUpdated";
            public const string ProviderInstrumentArchived = "ProviderInstrumentArchived";
            public const string ProviderInstrumentUpdated = "ProviderInstrumentUpdated";
            public const string ProviderArchived = "ProviderArchived";
            public const string ProviderUpdated = "ProviderUpdated";
            public const string QuoteUpdated = "QuoteUpdated";
            public const string SnapshotUpdated = "SnapshotUpdated";
            public const string TechnicalIndicatorArchived = "TechnicalIndicatorArchived";
            public const string TechnicalIndicatorUpdated = "TechnicalIndicatorUpdated";
            public const string TradeReceived = "TradeReceived";
        }
    }
}
