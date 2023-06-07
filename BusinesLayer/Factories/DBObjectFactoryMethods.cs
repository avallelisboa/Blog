using BusinessLayer.Entities;
using IDataAccess.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Factories
{
    public static class DBObjectFactoryMethods
    {
        public static UserDB makeUserDB(User theUser)
        {
            UserDB aUser = new UserDB();
            aUser.Email = theUser.Email;
            aUser.Name = theUser.Name;
            aUser.LastName = theUser.LastName;
            aUser.UserName = theUser.UserName;
            aUser.Password = theUser.Password;
            aUser.Role = theUser.Role;
            return aUser;
        }
        public static PostDB makePostDB(Post thePost)
        {
            PostDB aPost = new PostDB();
            aPost.Title = thePost.Tittle;
            aPost.Content = thePost.Content;
            aPost.PostCategories = thePost.Categories.Select(c => new PostCategoryDB(thePost.Id,c.Id)).ToList();
            aPost.WrittenDate = thePost.WrittenDate;
            aPost.ModifiedDate = thePost.ModifiedDate;
            aPost.Author = new UserDB(thePost.Author.Id);
            return aPost;
        }
        public static CategoryDB categoryDB(Category theCategory)
        {
            CategoryDB aCategory = new CategoryDB();

            return aCategory;
        }
    }
}
