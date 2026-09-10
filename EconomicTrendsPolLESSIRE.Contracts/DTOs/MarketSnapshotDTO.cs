using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class MarketSnapshotDTO
    {
        [Required]
        public int InstrumentId { get; set; }
        [Required]
        public decimal LastPrice { get; set; } = 0;
        [Required]
        public decimal BidPrice { get; set; } = 0;
        [Required]
        public decimal AskPrice { get; set; } = 0;
        [Required]
        public decimal OpenPrice { get; set; } = 0;
        [Required]
        public decimal HighPrice { get; set; } = 0;
        [Required]
        public decimal LowPrice { get; set; } = 0;
        [Required]
        public decimal PreviousClose { get; set; } = 0;
        [Required]
        public decimal Volume { get; set; } = 0;
        [Required]
        public int LastProviderId { get; set; }
        [Required]
        public DateTime MarketTimestampUtc { get; set; }
        [Required]
        public DateTime ReceivedAtUtc { get; set; }
    }
}
