using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstApproach.SrcData
{
    public class CarOwner
    {
        [Key]
        public int OwnerID { get; set; }
        public int CarID { get; set; }
        public string OwnerName { get; set; }
        public int Contact { get; set; }
        public string Address { get; set; }
        public DateTime PurchaseDate { get; set; }


        public CarDetails CarDetails { get; set; }
    }
}
