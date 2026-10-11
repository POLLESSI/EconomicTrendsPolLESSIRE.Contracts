namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed class MistralInteractionCompletedDto
    {
        public int Id { get; init; }
        public string Prompt { get; init; } = string.Empty;
        public string Response { get; init; } = string.Empty;
        public string? PromptHash { get; init; }
        public DateTime CreatedAt { get; init; }
        public bool Active { get; init; }

        public int? EventId { get; init; }
        public int? CrowdInfoId { get; init; }
        public int? PlaceId { get; init; }
        public int? TrafficConditionId { get; init; }
        public int? WeatherForecastId { get; init; }

        public double? Latitude { get; init; }
        public double? Longitude { get; init; }
        public string? SourceType { get; init; }
        public int? CrowdLevel { get; init; }
    }
}
