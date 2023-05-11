using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Entities
{
    public class Post : Entity
    {
        public Post() : base("Post")
        {

        }
        public Post(string theTittle, string theContent, List<Category> theCategories, DateTime theWrittenDate, User theUser) : base("Post")
        {
            Tittle = theTittle;
            Content = theContent;
            Categories = theCategories;
            WrittenDate = theWrittenDate;
        }
        public Post(string theTittle, string theContent, List<Category> theCategories, DateTime theWrittenDate, DateTime theModifiedDate, User theUser) : base("Post")
        {
            Tittle = theTittle;
            Content = theContent;
            Categories = theCategories;
            WrittenDate = theWrittenDate;
            ModifiedDate = theModifiedDate;
        }
        public Post(int theId,string theTittle, string theContent, List<Category> theCategories, DateTime theWrittenDate, DateTime theModifiedDate, User theUser) : base("Post")
        {
            Id = theId;
            Tittle = theTittle;
            Content = theContent;
            Categories = theCategories;
            WrittenDate = theWrittenDate;
            ModifiedDate = theModifiedDate;
        }
        public int Id { get; private set; }
        public string Tittle { get; private set; }
        public string Content { get; private set; }
        public List<Category> Categories {get; private set; }
        public DateTime WrittenDate { get; private set; }
        public DateTime ModifiedDate { get; private set; }
        public User Author { get; }
    }
}
