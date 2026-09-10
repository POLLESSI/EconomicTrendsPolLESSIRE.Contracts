using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
#nullable disable
    public class InstrumentDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Symbol { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int AssetClass { get; set; }
        [Required]
        public string ExchangeCode { get; set; }
        [Required]
        public string CurrencyCode { get; set; }
        [Required]
        public DateTime CreatedAtUtc { get; set; }
    }
}
