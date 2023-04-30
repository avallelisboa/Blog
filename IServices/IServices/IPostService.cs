using IServices.DTOs.Request.Post;
using IServices.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.IServices
{
    public interface IPostService
    {
        ActionResult makePost(AddPostRequest req);
        ActionResult getPost(int id);
        ActionResult getPosts();
        ActionResult updatePost();
        ActionResult deletePost(int id);
    }
}
