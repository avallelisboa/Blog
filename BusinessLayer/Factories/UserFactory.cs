using BusinessLayer.Entities;
using IDataAccess.DBObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Factories
{
    public class UserFactory : EntitiesAbstractFactory
    {
        public override Entity MakeNullable()
        {
            throw new NotImplementedException();
        }

        public override Entity MakeValid(DBObject theObject)
        {
            throw new NotImplementedException();
        }
    }
}
