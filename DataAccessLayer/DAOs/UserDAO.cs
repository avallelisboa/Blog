using IDataAccess.DBObjects;
using IDataAccess.IDAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.DAOs
{
    public class UserDAO : IUserDAO
    {
        public void Add(UserDB theObject)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                db.Users.Add(theObject);
            }
        }

        public void Delete(int id)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                UserDB user = db.Users.First(u => u.Id == id);
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public UserDB Get(int id)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Users.FirstOrDefault(u => u.Id == id);
            }
        }

        public void Update(UserDB theObject)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                UserDB user = db.Users.First(u => u.Id == theObject.Id);

                user.Email = theObject.Email;
                user.Name = theObject.Name;
                user.UserName = theObject.UserName;

                db.SaveChanges();
            }
        }
    }
}
