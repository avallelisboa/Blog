using BusinessLayer.Entities;
using IDataAccess.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Factories
{
    public class PostFactory : EntitiesAbstractFactory
    {
        private static PostFactory _instance;
        private PostFactory() { }
        public static PostFactory GetInstance()
        {
            if (_instance == null)
                _instance = new PostFactory();

            return _instance;
        }
        public override Entity MakeNullable()
        {
            throw new NotImplementedException();
        }

        public override Entity MakeValid(DBObject theObject)
        {
            PostDB dbPost = (PostDB)theObject;
            Post aPost = new Post(
                dbPost.Id, dbPost.Title, dbPost.Content,
                dbPost.PostCategories.Select(pc => new Category(pc.CategoryId,pc.Category.Name)).ToList(),
                dbPost.WrittenDate, dbPost.ModifiedDate, new User(dbPost.Id)
            );

            return aPost;
        }
    }
}
