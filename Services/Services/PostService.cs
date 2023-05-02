using IDataAccess.IDAOs;
using IServices.DTOs.Request.Post;
using IServices.DTOs.Response;
using IServices.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class PostService : IPostService
    {
        private readonly IPostDAO _postDAO;
        public PostService(IPostDAO thePostDAO)
        {
            _postDAO = thePostDAO;
        }
        public ActionResult deletePost(int id)
        {
            try
            {
                return _deletePost(id);
            }
            catch (Exception ex)
            {
                return new ActionResult
                {
                    isValid = false,
                    message = ex.Message
                };
            }
        }
        private ActionResult _deletePost(int id)
        {
            ActionResult result = new ActionResult
            {
                isValid = true,
                message = "The post was deleted correctly"
            };

            _postDAO.Delete(id);

            return result;
        }

        public ActionResult getPost(int id)
        {
            try
            {
                return _getPost(id);
            }
            catch (Exception ex)
            {
                return new ActionResult
                {
                    isValid = false,
                    message = ex.Message
                };
            }
        }
        private ActionResult _getPost(int id)
        {
            ActionResult result = new ActionResult
            {
                isValid = true,
                message = "The post was founded correctly"
            };

            var post = _postDAO.Get(id);

            return result;
        }

        public ActionResult getPosts()
        {
            try
            {
                return _getPosts();
            }
            catch (Exception ex)
            {
                return new ActionResult
                {
                    isValid = false,
                    message = ex.Message
                };
            }
        }
        private ActionResult _getPosts()
        {
            ActionResult result = new ActionResult
            {
                isValid = false,
                message = ""
            };


            return result;
        }

        public ActionResult makePost(AddPostRequest req)
        {
            try
            {
                return _makePost(req);
            }
            catch (Exception ex)
            {
                return new ActionResult
                {
                    isValid = false,
                    message = ex.Message
                };
            }
        }
        private ActionResult _makePost(AddPostRequest req)
        {
            ActionResult result = new ActionResult
            {
                isValid = false,
                message = ""
            };


            return result;
        }

        public ActionResult updatePost()
        {
            try
            {
                return _updatePost();
            }
            catch (Exception ex)
            {
                return new ActionResult
                {
                    isValid = false,
                    message = ex.Message
                };
            }
        }
        private ActionResult _updatePost()
        {
            ActionResult result = new ActionResult
            {
                isValid = false,
                message = ""
            };


            return result;
        }
    }
}
