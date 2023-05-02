using IDataAccess.DBObjects;
using IDataAccess.IDAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.DAOs
{
    public class PostDAO : IPostDAO
    {
        public void Add(PostDB theObject)
        {
            using(BlogDBContext db = new BlogDBContext())
            {
                db.Posts.Add(theObject);
            }
        }

        public void Delete(int id)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                PostDB post = db.Posts.First(p => p.Id == id);
                db.Posts.Remove(post);
                db.SaveChanges();
            }
        }

        public PostDB Get(int id)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Posts.FirstOrDefault(p => p.Id == id);
            }
        }

        public void Update(PostDB theObject)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                PostDB post = db.Posts.First(p => p.Id == theObject.Id);

                post.Title = theObject.Title;
                post.Content = theObject.Content;
                post.Author = theObject.Author;
                post.PostCategories = theObject.PostCategories;
                post.ModifiedDate = theObject.ModifiedDate;

                db.SaveChanges();
            }            
        }
    }
}
