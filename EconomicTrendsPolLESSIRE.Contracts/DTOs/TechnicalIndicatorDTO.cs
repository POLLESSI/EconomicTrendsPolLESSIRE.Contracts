using System.ComponentModel.DataAnnotations;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class TechnicalIndicatorDTO
    {
        [Required]
        public int InstrumentId { get; set; }
        [Required]
        public int IntervalCode { get; set; }
        [Required]
        public DateTime TimestampUtc { get; set; }
        [Required]
        public int IndicatorType { get; set; }
        [Required]
        public decimal Value1 { get; set; }
        [Required]
        public decimal Value2 { get; set; }
        [Required]
        public decimal Value3 { get; set; }
        [Required]
        public byte ParameterHash { get; set; }
    }
}
