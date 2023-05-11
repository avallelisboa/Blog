using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.User
{
    public class UpdateUserModel
    {
        [Required(ErrorMessage = "The email cannot be empty")]
        [MinLength(10, ErrorMessage = "The email must have at least 10 characters")]
        [MaxLength(50, ErrorMessage = "The email must have at least 50 characters")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "The name cannot be empty")]
        [MinLength(4, ErrorMessage = "The name must have at least 4 characters")]
        [MaxLength(15, ErrorMessage = "The name must have at least 15 characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required(ErrorMessage = "The last name cannot be empty")]
        [MinLength(4, ErrorMessage = "The last name must have at least 4 characters")]
        [MaxLength(20, ErrorMessage = "The last name must have at least 20 characters")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The username cannot be empty")]
        [MinLength(4, ErrorMessage = "The username must have at least 4 characters")]
        [MaxLength(20, ErrorMessage = "The username must have at least 20 characters")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "The old password cannnot be empty")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "The password cannnot be empty")]
        [MinLength(4, ErrorMessage = "The password must have at least 4 characters")]
        [MaxLength(20, ErrorMessage = "The password must have at least 20 characters")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "The passwords do not match")]
        public string VerifyNewPassword { get; set; }
    }
}
