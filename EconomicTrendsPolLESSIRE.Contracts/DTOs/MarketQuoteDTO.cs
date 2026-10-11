using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class MarketQuoteDTO
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public long InstrumentId { get; set; }
        [Required]
        public int ProviderId { get; set; }
        [Required]
        public DateTime TimestampUtc { get; set; }
        [Required]
        public DateTime ReceivedAtUtc { get; set; }
        [Required]
        public decimal BidPrice { get; set; }
        [Required]
        public decimal BidSize { get; set; } = 0;
        [Required]
        public decimal AskPrice { get; set; }
        [Required]
        public decimal AskSize { get; set; } = 0;
    }
}
