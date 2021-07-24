using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CJSTUFF.Models
{
    public class Register
    {
        [Key]
        public int RegisterId { get; set; }
        [Required(ErrorMessage = "Required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Required.")]
        [Display(Name = "Contact Number")]
        public int ContactNo { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Required.")]
        public string Address { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
