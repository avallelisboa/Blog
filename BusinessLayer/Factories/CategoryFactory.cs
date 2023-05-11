using BusinessLayer.Entities;
using IDataAccess.DBObjects;
using System;
using System.Collections.Generic;
using System.Text;
namespace BusinessLayer.Factories
{
    public class CategoryFactory : EntitiesAbstractFactory
    {
        public override Entity MakeNullable()
        {
            throw new NotImplementedException();
        }
        public override Entity MakeValid(DBObject theObject)
        {
            CategoryDB categoryDB = (CategoryDB)theObject;
            Category category = new Category(categoryDB.Id, categoryDB.Name);

            return category;
        }
     }
}
