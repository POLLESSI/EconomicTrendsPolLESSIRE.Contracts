namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class MarketTradeDTO
    {
        public int Id { get; set; }
        public int InstrumentId { get; set; }
        public int ProviderId { get; set; }
        public DateTime TimestampUtc { get; set; }
        public DateTime ReceivedAtUtc { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public int SequenceNumber { get; set; }
    }
}
