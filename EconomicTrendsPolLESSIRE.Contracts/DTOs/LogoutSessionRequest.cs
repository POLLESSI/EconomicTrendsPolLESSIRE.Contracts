namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed record LogoutSessionRequest
    {
        public string Email { get; init; } = string.Empty;

        public string RefreshToken { get; init; } = string.Empty;
    }
}
