using EconomicTrendsPolLESSIRE.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class MessageTriageResultDTO
    {
        [Required]
        public bool RequiresAdminReview { get; init; }
        [Required]
        public AdminMessageCategory Category { get; init; }
        [Required]
        public byte Priority { get; init; }
        [Required]

        public double Confidence { get; init; }
        [Required]

        public string ClassificationSource { get; init; } = "Rules";
    }
}
