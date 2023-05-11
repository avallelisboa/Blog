using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDataAccess.DBObjects
{
    [Table(name:"Post")]
    public class PostDB :DBObject
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime WrittenDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public UserDB Author { get; set; }
        public List<PostCategoryDB> PostCategories { get; set; }
        [NotMapped]
        public List<CategoryDB> Categories { get; set; }
    }
}
