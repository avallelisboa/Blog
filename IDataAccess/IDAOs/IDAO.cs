using IDataAccess.DBObjects;
using IDataAccess.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDataAccess.IDAOs
{
    public interface IDAO<T> where T : class
    {
        ActionResult Add(T theObject);
        T Get(int id);
        ActionResult Update(T theObject);
        ActionResult Delete(int id);
    }
}
