using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudWithDb.Models
{
    public class Emp
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        public int salary { get; set; }

        // Foreign key
        public int LanguageId { get; set; }

        [ForeignKey("LanguageId")]
        public Language Language { get; set; }
    }
}
