namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public sealed class AdminMessageQueueFilter
    {
        public string? Status { get; set; }
        public string? Category { get; set; }
        public byte? Priority { get; set; }
        public int Take { get; set; } = 200;
    }
}
