using BusinessLayer.Entities;
using IServices.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.Factories
{
    public class CategoryDTOFactory : DTOsAbstractFactory
    {
        public override ActionResult makeValidDTO(Entity theEntity)
        {
            Category category = (Category)theEntity;
            return new CategoryResponse
            {
                isValid = true,
                message ="",
                Name = category.Name
            };
        }
    }
}
