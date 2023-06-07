using BusinessLayer.Entities;
using IDataAccess.DBObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Factories
{
    public abstract class EntitiesAbstractFactory
    {
        public Entity MakeEntity(DBObject theObject)
        {
            switch (theObject)
            {
                case null:
                    return MakeNullable();
                default:
                    return MakeValid(theObject);
            }
        }
        public abstract Entity MakeNullable();
        public abstract Entity MakeValid(DBObject theObject);
    }
}
