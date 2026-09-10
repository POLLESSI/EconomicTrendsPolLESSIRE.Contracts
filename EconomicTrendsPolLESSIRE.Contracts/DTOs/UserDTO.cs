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
        public string PasswordHachV2 { get; set; }
        [Required]
        public Guid SecurityStamp { get; set; }
        [Required]
        public int Role { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
