using EconomicTrendsPolLESSIRE.Contracts.Enums;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed class UserPublicDTO
    {
        public int Id { get; init; }
        public string Email { get; init; } = string.Empty;
        public UserRole Role { get; init; } 
        public UserStatus Status { get; init; } 
        public bool Active { get; init; }
    }
}
