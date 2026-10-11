namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed class MistralStartResponseDto
    {
        public bool Accepted { get; set; }
        public int InteractionId { get; init; }
        public string RequestId { get; init; } = string.Empty;
        public DateTime StartedAtUtc { get; set; }
        public string Status { get; init; } = "accepted";
        public string? Message { get; set; }
    }
}
