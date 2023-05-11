using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Entities
{
    public class Category : Entity
    {
        public Category() : base("Category"){}
        public Category(int theId) : base("Category")
        {
            Id = theId;
        }
        public Category(int theId, string theName) : base("Category")
        {
            Id = Id;
            Name = theName;
        }
        public List<Post> Posts { get; private set; }
        public int Id { get; private set; }
        public string Name { get; private set; }

        public void ChangeName(string newName)
        {
            Name = newName;
        }
    }
}
