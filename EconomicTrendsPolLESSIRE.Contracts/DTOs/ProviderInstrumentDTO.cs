using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class ProviderInstrumentDTO
    {
    #nullable disable
        [Required]
        public int ProviderId { get; set; }
        [Required]
        public int InstrumentId { get; set; }
        [Required]
        public string ProviderSymbol { get; set; }
        [Required]
        public bool Realtime { get; set; }
        [Required]
        public int DelaySeconds { get; set; }
    }
}
