using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.DTOs.Request.Post
{
    public class UpdatePostRequest
    {
        public int PostId;
        public string Title;
        public string Content;
        public List<int> CategoriesId;
    }
}
