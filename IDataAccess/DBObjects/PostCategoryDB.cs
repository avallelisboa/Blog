using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDataAccess.DBObjects
{
    [Table(name:"PostsCategoryies")]
    public class PostCategoryDB
    {
        public int PostId { get; set; }
        public int CategoryId { get; set; }
        public PostDB Post { get; set; }
        public CategoryDB Category { get; set; }
    }
}
