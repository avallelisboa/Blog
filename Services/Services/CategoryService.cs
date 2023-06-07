using IDataAccess.IDAOs;
using IServices.DTOs.Request.Category;
using IServices.DTOs.Response;
using IServices.Factories;
using IServices.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryDAO _categoryDAO;
        public CategoryService(ICategoryDAO theCategoryDAO)
        {
            _categoryDAO = theCategoryDAO;
        }
        public ActionResult addCategory(AddCategoryRequest theRequest)
        {
            try
            {
                return _addCategory(theRequest);
            }
            catch(Exception ex)
            {
                return CategoryDTOFactory.GetInstance().makeInvalidDTO(ex);
            }
        }

        public ActionResult getCategories(int postId)
        {
            try
            {
                return _getCategories(postId);
            }
            catch(Exception ex)
            {
                return CategoryDTOFactory.GetInstance().makeInvalidDTO(ex);
            }
        }
        private ActionResult _getCategories(int postId)
        {
            ActionResult result = new ActionResult
            {
                isValid = false,
                message = ""
            };
            var categories = _categoryDAO.GetCategoriesByPostId(postId);

            return result;
        }

        private ActionResult _addCategory(AddCategoryRequest theRequest)
        {
            ActionResult result = new ActionResult 
            {
                isValid = false,
                message = ""
            };


            return result;
        }

        public ActionResult getCategories()
        {
            throw new NotImplementedException();
        }
    }
}
