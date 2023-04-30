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
        ) : base("User")
        {
            Id = id; UserName = userName; Email = email; Name = name;
            LastName = lastName; Password = password; Role = role;
        }
        public int Id { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
    }
}
