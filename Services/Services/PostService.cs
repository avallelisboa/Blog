using BusinessLayer.BL;
using BusinessLayer.Entities;
using BusinessLayer.Factories;
using IDataAccess.DBObjects;
using IDataAccess.IDAOs;
using IServices.DTOs.Request.Post;
using IServices.DTOs.Response;
using IServices.Factories;
using IServices.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var post = _postDAO.Get(id);
            var entity = PostFactory.GetInstance().MakeEntity(post);
            var res = (PostResponse)PostDTOFactory.GetInstance().makeValidDTO(entity);
            if (!res.isValid)
                res.message = "The post was founded.";

            return res;
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
            GetPostsResponse res = new GetPostsResponse();
            var posts = _postDAO.GetAll();
            var entities = posts.Select(p => PostFactory.GetInstance().MakeEntity(p)).ToList();
            List<PostResponse> postsResponse = entities.Select(p => (PostResponse)PostDTOFactory.GetInstance().makeValidDTO(p) ).ToList();
            res.posts = postsResponse;
            return res;
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
                isValid = true,
                message = ""
            };
            Post entity = new Post(req.Title, req.Content, req.CategoryIds.Select(c => new Category(c)).ToList(), DateTime.Now, new User(req.userId));
            var validationResult = PostBL.GetInstance().IsValid(entity);
            if (!validationResult.IsValid)
            {
                result.isValid = false;
                result.message = validationResult.Message;
            }
            PostDB p = DBObjectFactoryMethods.makePostDB(entity);
            _postDAO.Add(p);

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

        public ActionResult getPostsBetweenDates(DateTime d1, DateTime d2)
        {
            throw new NotImplementedException();
        }

        public ActionResult getPostsByYear(int year)
        {
            throw new NotImplementedException();
        }

        public ActionResult getPostsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public ActionResult updatePost(UpdatePostRequest req)
        {
            throw new NotImplementedException();
        }
    }
}
