using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IDataAccess.DBObjects
{
    [Table(name:"User")]
    public class UserDB : DBObject
    {
        [Key]
        public int Id { get; set; }
        [DataType(dataType: DataType.EmailAddress)]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
    }
}
