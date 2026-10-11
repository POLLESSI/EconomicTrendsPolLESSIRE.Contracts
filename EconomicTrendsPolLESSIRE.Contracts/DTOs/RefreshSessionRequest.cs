namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed record RefreshSessionRequest
    {
        public string Email { get; init; } = string.Empty;

        public string RefreshToken { get; init; } = string.Empty;
    }
}
