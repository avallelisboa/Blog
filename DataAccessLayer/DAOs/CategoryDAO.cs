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
