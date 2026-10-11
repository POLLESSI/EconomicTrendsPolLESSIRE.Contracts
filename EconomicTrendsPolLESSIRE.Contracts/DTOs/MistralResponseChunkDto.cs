namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed class MistralResponseChunkDto
    {
        public int InteractionId { get; init; }
        public string RequestId { get; init; } = string.Empty;
        public string Chunk { get; init; } = string.Empty;
        public bool IsFinal { get; init; }
    }
}
