using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Entities
{
    public class Category : Entity
    {
        public Category() : base("Category")
        {

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
