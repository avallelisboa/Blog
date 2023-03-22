using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLayer.Entities
{
    public class User : Entity
    {
        public User(
            int id, string userName, string email,string name,
            string lastName, string password, string role
        )
        {
            Id = id; UserName = userName; Email = email; Name = name;
            LastName = lastName; Password = password; Role = role;
        }
        public int Id { get; private set; }
        public string UserName { get; private set; }
        [DataType(DataType.EmailAddress,ErrorMessage = "The email is not valid.")]
        [MaxLength(100,ErrorMessage = "The email must not be larger than 100 characters.")]
        [MinLength(10, ErrorMessage = "The email must not be shorter than 10 character.")]
        public string Email { get; private set; }
        
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
    }
}
