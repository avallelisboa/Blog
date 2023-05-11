using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.DTOs.Response
{
    public class PostResponse : ActionResult
    {
        public int Id;
        public string Tittle;
        public string Content;
        public List<CategoryResponse> Categories;
        public DateTime WrittenDate;
        public DateTime ModifiedDate;
        public string Author;
    }
}
