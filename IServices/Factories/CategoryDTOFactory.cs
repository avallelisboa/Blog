using BusinessLayer.Entities;
using IDataAccess.DBObjects;
using IServices.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.Factories
{
    public class CategoryDTOFactory : DTOsAbstractFactory
    {
        private static CategoryDTOFactory _instance;
        public static CategoryDTOFactory GetInstance()
        {
            if (_instance == null)
                _instance = new CategoryDTOFactory();

            return _instance;
        }
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

        public override ActionResult makeValidDTO(DBObject theDBObject)
        {
            CategoryDB category = (CategoryDB)theDBObject;
            return new CategoryResponse
            {
                isValid = true,
                message = "",
                Id = category.Id,
                Name = category.Name
            };
        }
    }
}
