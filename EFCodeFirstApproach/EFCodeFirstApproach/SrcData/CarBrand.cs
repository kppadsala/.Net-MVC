using System.ComponentModel.DataAnnotations;
namespace EFCodeFirstApproach.SrcData
{
    public class CarBrand
    {
        [Key]
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }


        public ICollection<CarDetails> CarDetails { get; set; }
    }
}
