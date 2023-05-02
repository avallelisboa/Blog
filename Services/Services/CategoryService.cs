using IDataAccess.IDAOs;
using IServices.DTOs.Request.Category;
using IServices.DTOs.Response;
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
                return new ActionResult
                {
                    isValid = false,
                    message = ex.Message
                };
            }
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
    }
}
