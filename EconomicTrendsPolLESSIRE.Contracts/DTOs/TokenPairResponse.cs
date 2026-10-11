namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed record TokenPairResponse
    {
        public string AccessToken { get; init; } = string.Empty;

        public string RefreshToken { get; init; } = string.Empty;
    }
}
