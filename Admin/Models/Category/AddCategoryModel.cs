using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Category
{
    public class AddCategoryModel
    {
        [Required(ErrorMessage = "The category name cannot be empty")]
        [MinLength(4, ErrorMessage = "The category name must have at least 4 characters")]
        [MaxLength(20, ErrorMessage = "The category name cannot have more than 20 characters")]
        public string CategoryName { get; set; }
    }
}