using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstApproach.SrcData
{
    public class CarDetails
    {
        [Key]
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public int TypeID { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public DateTime CreatedAt { get; set; }



        public CarBrand CarBrand { get; set; }
        public CarType CarType { get; set; }

        public ICollection<CarOwner> CarOwner { get; set; }
    }
}
