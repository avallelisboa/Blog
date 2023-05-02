using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.DTOs.Response
{
    class PostResponse : ActionResult
    {
        public int Id;
        public string Tittle;
        public string Content;
        public string[] Categories;
        public DateTime WrittenDate;
        public DateTime ModifiedDate;
        public string Author;
    }
}
