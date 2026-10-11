namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed class MistralResponseStartedDto
    {
        public int InteractionId { get; init; }
        public string RequestId { get; init; } = string.Empty;
        public DateTime StartedAtUtc { get; init; }
    }
}
