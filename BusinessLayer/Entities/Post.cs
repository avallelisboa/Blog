using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Entities
{
    public class Post : Entity
    {
        public int Id { get; private set; }
        public string Tittle { get; private set; }
        public string Content { get; private set; }
        public DateTime WrittenDate { get; private set; }
        public DateTime ModifiedDate { get; private set; }
        public User Author { get; }
    }
}
