using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed class MistralPromptRequest
    {
        [Required]
        [StringLength(8000, MinimumLength = 1)]
        public string Prompt { get; set; } = string.Empty;

        [Range(-90d, 90d)]
        public double? Latitude { get; set; }

        [Range(-180d, 180d)]
        public double? Longitude { get; set; }

        [StringLength(16)]
        public string? LanguageCode { get; set; } = "fr-FR";
    }
}