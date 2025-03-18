using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstApproach.SrcData
{
    public class CarType
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }


        public ICollection<CarDetails> CarDetails { get; set; }
    }
}
