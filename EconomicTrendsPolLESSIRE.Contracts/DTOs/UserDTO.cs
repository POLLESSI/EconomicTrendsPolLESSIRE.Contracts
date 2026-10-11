using EconomicTrendsPolLESSIRE.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class UserDTO
    {
    #nullable disable
        [Required]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PasswordHashV2 { get; set; }
        [Required]
        public Guid SecurityStamp { get; set; }
        [Required]
        public UserRole Role { get; set; }

        [Required]
        public UserStatus Status { get; set; }

        public bool Active { get; set; }
    }
}
