using IDataAccess.DBObjects;
using IDataAccess.IDAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.DAOs
{
    public class CategoryDAO : ICategoryDAO
    {
        public void Add(CategoryDB theObject)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                db.Categories.Add(theObject);
            }
        }

        public void Delete(int id)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                CategoryDB cat = db.Categories.First(c => c.Id == id);
                db.Categories.Remove(cat);
                db.SaveChanges();
            }
        }

        public CategoryDB Get(int id)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Categories.FirstOrDefault(c => c.Id == id);
            }
        }

        public List<CategoryDB> GetAll()
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Categories.ToList();
            }
        }

        public List<CategoryDB> GetCategoriesByPostId(int postId)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Categories.Join(
                    db.PostsCategories,
                    cat => cat.Id,
                    postcat => postcat.CategoryId,
                    (cat, postcat) => new
                    {
                        CategoryId = cat.Id,
                        CategoryName = cat.Name,
                        PostId = postcat.PostId,
                    }).Where(postcat => postcat.PostId == postId)
                    .Select(postcat => new CategoryDB
                    {
                        Id = postcat.CategoryId,
                        Name = postcat.CategoryName
                    }).ToList();
            }
        }

        public void Update(CategoryDB theObject)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                CategoryDB cat = db.Categories.First(c => c.Id == theObject.Id);

                cat.Name = theObject.Name;
                cat.PostCategories = theObject.PostCategories;

                db.SaveChanges();
            }
        }
    }
}
