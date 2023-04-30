using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BL
{
    public class CategoryBL : EntityBL
    {
        private static CategoryBL _instance;
        private CategoryBL() { }
        public static CategoryBL GetInstance()
        {
            if (_instance == null)
                _instance = new CategoryBL();

            return _instance;
        }
        public EntityValidationResult validateId(int id)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
        public EntityValidationResult validateName(string Name)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
    }
}
