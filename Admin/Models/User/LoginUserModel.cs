using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.User
{
    public class LoginUserModel
    {
        [Required(ErrorMessage = "The username cannot be empty")]
        [MinLength(4, ErrorMessage = "The username must have at least 4 characters")]
        [MaxLength(20, ErrorMessage = "The username must have at least 20 characters")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "The password cannnot be empty")]
        [MinLength(4, ErrorMessage = "The password must have at least 4 characters")]
        [MaxLength(20, ErrorMessage = "The password must have at least 20 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
