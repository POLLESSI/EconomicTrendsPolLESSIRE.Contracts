using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EconomicTrendsPolLESSIRE.Contracts.DTOs
{
    public class PlaceDTO
    {
    #nullable disable
        public int Id { get; set; }
        [Required]
        [DisplayName("Place Name : ")]
        public string Name { get; set; } = "";
        [Required]
        [DisplayName("Place Type : ")]
        public string Type { get; set; } = "";
        [Required]
        [DisplayName("Indoor ? : ")]
        public bool Indoor { get; set; }
        [Required]
        [DisplayName("Latitude : ")]
        public decimal Latitude { get; set; }
        [Required]
        [DisplayName("Longitude : ")]
        public decimal Longitude { get; set; }
        [Required]
        [DisplayName("Capacity : ")]
        public int Capacity { get; set; }
        [DisplayName("Tags : ")]
        public string Tag { get; set; } = "";
        public bool Active { get; set; } = true;
    }
}
