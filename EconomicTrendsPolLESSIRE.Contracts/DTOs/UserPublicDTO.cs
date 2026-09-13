namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed class UserPublicDTO
    {
        public int Id { get; init; }
        public string Email { get; init; } = string.Empty;
        public string Role { get; init; } = string.Empty;
        public string Status { get; init; } = string.Empty;
        public bool Active { get; init; }
    }
}
