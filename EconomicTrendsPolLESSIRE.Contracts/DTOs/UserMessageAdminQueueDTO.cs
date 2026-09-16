using EconomicTrendsPolLESSIRE.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class UserMessageAdminQueueDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int MessageId { get; set; }
        [Required]
        public AdminMessageCategory Category { get; set; }
        [Required]
        public byte Priority { get; set; } = 1;
        [Required]
        public AdminMessageStatus Status { get; set; } = AdminMessageStatus.Open;
        public decimal? Confidence { get; set; }
        [Required]
        public string ClassificationSource { get; set; } = "Rules";
        public string? AssignedTo { get; set; }
        public string? AdminNote { get; set; }
        [Required]
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAtUtc { get; set; }
        public DateTime? ResolvedAtUtc { get; set; }
    }
}
