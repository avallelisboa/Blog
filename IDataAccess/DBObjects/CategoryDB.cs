using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDataAccess.DBObjects
{
    [Table(name:"Category")]
    public class CategoryDB : DBObject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PostCategoryDB> PostCategories { get; set; }
    }
}
