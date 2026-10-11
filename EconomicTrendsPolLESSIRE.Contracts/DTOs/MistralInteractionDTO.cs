namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class MistralInteractionDTO
    {
        public int Id { get; set; }

        public string Prompt { get; set; } = string.Empty;

        public string Response { get; set; } = string.Empty;

        public string PromptHash { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public bool Active { get; set; }

        public string? Model { get; set; }

        public float? Temperature { get; set; }

        public int? TokenCount { get; set; }

        // =====================================================
        // OPTIONAL MARKET CONTEXT
        // =====================================================

        public long? InstrumentId { get; set; }

        public long? MarketQuoteId { get; set; }

        public long? MarketTradeId { get; set; }

        public int? ProviderId { get; set; }

        public int? MarketCandleIntervalCode { get; set; }

        public DateTime? MarketCandleOpenTimeUtc { get; set; }

        public int? TechnicalIndicatorIntervalCode { get; set; }

        public int? TechnicalIndicatorType { get; set; }

        public DateTime? TechnicalIndicatorTimestampUtc { get; set; }

        // =====================================================
        // LOCATION SNAPSHOT
        // =====================================================
        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string? SourceType { get; set; }
        public string? ExecutionSource { get; set; }
        public string? Status { get; set; }
    }
}
































































































// Copyrigtht (c) EconomicTrendsPolLESSIRE https://github.com/POLLESSI/EconomicTrendsPolLESSIRE. All rights reserved.