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

        public List<PostDB> GetAll()
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Posts.ToList();
            }
        }

        public List<PostDB> GetPostsByAuthor(int authorId)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Posts.Where(p => p.Author.Id == authorId).ToList();
            }
        }

        public List<PostDB> GetPostsByCategory(int categoryId)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Posts.Join(
                    db.PostsCategories,
                    post => post.Id,
                    postcat => postcat.PostId,
                    (post, postcat) => new { Post = post, PostCat = postcat }
                    ).Join(
                    db.Categories,
                        postcat => postcat.PostCat.CategoryId,
                        cat => cat.Id,
                        (postcat, cat) => new { Post = postcat, PostCat = postcat, Cat = cat }
                    ).Where(pc => pc.Cat.Id == categoryId).Select(p => new PostDB
                    {
                        Id = p.Post.Post.Id,
                        Title = p.Post.Post.Title,
                        Content = p.Post.Post.Content,
                        Author = p.Post.Post.Author,
                        WrittenDate = p.Post.Post.WrittenDate,
                        ModifiedDate = p.Post.Post.ModifiedDate
                    }).ToList();
            }
        }

        public List<PostDB> GetPostsByDateRange(DateTime d1, DateTime d2)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Posts.Where(p => p.WrittenDate >= d1 && p.WrittenDate <= d2).ToList();
            }
        }

        public List<PostDB> GetPostsByYear(int year)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Posts.Where(p => p.WrittenDate.Year == year).ToList();
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
