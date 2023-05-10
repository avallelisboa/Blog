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
            aResult.IsValid = id > 0;
            aResult.Message = !aResult.IsValid ? "The id must be higher than 0" : "";

            return aResult;
        }
        public EntityValidationResult validateName(string theName)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };
            aResult.IsValid = theName.Length > 3 && theName.Length <= 20;
            aResult.Message = !aResult.IsValid ? "The category name must be between 3 and 20 characters" : "";

            return aResult;
        }
    }
}
