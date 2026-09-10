using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class UserSessionsDTO
    {
    #nullable disable
        [Required]
        public int Id { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string Jti { get; set; }
        [Required]
        public Guid RefreshFamilyId { get; set; }
        [Required]
        public DateTime IssueAtUtc { get; set; }
        [Required]
        public DateTime ExpiresAtUtc { get; set; }
        [Required]
        public DateTime LastSeenUtc { get; set; }
        [Required]
        public int Source { get; set; }
        [Required]
        public string? Ip { get; set; }
        [Required]
        public string? UserAgent { get; set; }
    }
}
