using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class MarketCandleDTO
    {
        [Required]
        public int InstrumentId { get; set; }
        [Required]
        public int IntervalCode { get; set; }
        [Required]
        public DateTime OpenTimeUtc { get; set; }
        [Required]
        public decimal OpenPrice { get; set; }
        [Required]
        public decimal HighPrice { get; set; }
        [Required]
        public decimal LowPrice { get; set; }
        [Required]
        public decimal ClosePrice { get; set; }
        [Required]
        public decimal Volume { get; set; }
        [Required]
        public decimal VWAP { get; set; }
        [Required]
        public int TradeCount { get; set; }
        [Required]
        public bool IsFinal { get; set; }
    }
}
