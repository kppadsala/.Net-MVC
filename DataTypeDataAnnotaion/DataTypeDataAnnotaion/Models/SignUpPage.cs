using System.ComponentModel.DataAnnotations;

namespace DataTypeDataAnnotaion.Models
{
    public class SignUpPage
    {

        [Required(ErrorMessage ="Enter Your Name")]
        public string EmpName { get; set; }


        [Required(ErrorMessage ="Enter Your Address")]
        [DataType(DataType.MultilineText)]
        public string EmpAddress { get; set; }

        [Required(ErrorMessage = "Enter Your Password")]
        [DataType(DataType.Password)]

        public string EmpPassword { get; set; }

        [Required(ErrorMessage = "Enter Your Confrom password")]
        [DataType(DataType.Password)]
        [Compare("EmpPassword", ErrorMessage ="Password And Conform Password Is  Not Match")]
        public string EmpConformPassword { get; set; }

        [Required (ErrorMessage = "Enter Your Joining Data")]
        [DataType(DataType.Date)]

        public string EmpJoiningDate { get; set; }

        [Required(ErrorMessage = "Enter Your Worktime")]
        [DataType(DataType.Time)]

        public string EmpWorkStaringTime { get; set; }

    }
}
