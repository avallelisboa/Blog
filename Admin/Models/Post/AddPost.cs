using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Post
{
    public class AddPost
    {
        [Required(ErrorMessage ="")]
        [MinLength(4, ErrorMessage ="")]
        [MaxLength(30, ErrorMessage ="")]
        public string Title { get; set; }
        [Required]
        [MinLength(10, ErrorMessage ="")]
        [MaxLength(10000, ErrorMessage ="")]
        public string Content { get; set; }
        public int[] Categories { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}