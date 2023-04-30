using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BL
{
    public class PostBL : EntityBL
    {
        private PostBL() { }
        private static PostBL _instance;
        public static PostBL GetInstance()
        {
            if (_instance == null)
                _instance = new PostBL();

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
        public EntityValidationResult validateTitle(string title)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
        public EntityValidationResult validateContent(string content)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
        public EntityValidationResult validateWrittenDate(DateTime writtenDate)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
        public EntityValidationResult validateModifiedDate(DateTime modifiedDate)
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
