using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.DTOs.Response
{
    public class GetPostsResponse : ActionResult
    {
        public List<PostResponse> posts;
    }
}
