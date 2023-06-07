using IServices.DTOs.Request.Category;
using IServices.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.IServices
{
    public interface ICategoryService
    {
        ActionResult addCategory(AddCategoryRequest theRequest);
        ActionResult getCategories(int postId);
        ActionResult getCategories();
    }
}
