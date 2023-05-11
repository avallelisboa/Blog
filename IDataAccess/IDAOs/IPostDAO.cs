using IDataAccess.DBObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDataAccess.IDAOs
{
    public interface IPostDAO : IDAO<PostDB>
    {
        List<PostDB> GetPostsByCategory(int categoryId);
        List<PostDB> GetPostsByAuthor(int authorId);
        List<PostDB> GetPostsByYear(int year);
        List<PostDB> GetPostsByDateRange(DateTime d1, DateTime d2);
    }
}
