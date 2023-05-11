using IDataAccess.DBObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDataAccess.IDAOs
{
    public interface IDAO<T> where T : class
    {
        void Add(T theObject);
        T Get(int id);
        List<T> GetAll();
        void Update(T theObject);
        void Delete(int id);
    }
}
