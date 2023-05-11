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
        public UserDB() { }
        public UserDB(int theId)
        {
            Id = theId;
        }
        public UserDB(string theEmail,string theUserName, string thePassword, string theName, string theLastName, string theRole)
        {
            Email = theEmail; UserName = theUserName; Password = thePassword;
            Name = theName; LastName = theName; Role = theRole;
        }
        [Key]
        public int Id { get; set; }
        [DataType(dataType: DataType.EmailAddress)]
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
