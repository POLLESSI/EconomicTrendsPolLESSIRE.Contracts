using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class ProfanityWordDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Word { get; set; } = string.Empty;
        [Required]
        public string NormalizedWord { get; set; } = string.Empty;
        [Required]
        public string LanguageCode { get; set; } = "fr";
        [Required]
        public int Weight { get; set; } = 1;
        [Required]
        public bool IsRegex { get; set; }
        public string? Category { get; set; }
        [Required]
        public DateTime CreatedAtUtc { get; set; }
        public DateTime? UpdatedAtUtc { get; set; }
    }
}
