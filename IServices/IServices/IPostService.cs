using IServices.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.IServices
{
    public interface IPostService
    {
        ActionResult makePost();
        ActionResult getPost();
        ActionResult getPosts();
        ActionResult updatePost();
        ActionResult deletePost(int id);
    }
}
