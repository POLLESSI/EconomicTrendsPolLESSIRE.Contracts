namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed class MistralResponseStatusDto
    {
        public int InteractionId { get; init; }
        public string RequestId { get; init; } = string.Empty;
        public string Status { get; init; } = string.Empty;
        public string? Message { get; init; }
        public DateTime TimestampUtc { get; init; }
    }
}
