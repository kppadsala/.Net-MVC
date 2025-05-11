using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudWithDb.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Desc { get; set; }

        public ICollection<Emp> EmpList { get; set; }
    }
}
