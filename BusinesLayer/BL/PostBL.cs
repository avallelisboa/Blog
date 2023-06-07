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
            aResult.IsValid = id > 0;
            aResult.Message = !aResult.IsValid ? "The id must be higher than 0" : "";

            return aResult;
        }
        public EntityValidationResult validateTitle(string theTitle)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };
            aResult.IsValid = theTitle.Length > 3 && theTitle.Length <= 30;
            aResult.Message = !aResult.IsValid ? "The title must be between 3 and 30 characters" : "";

            return aResult;
        }
        public EntityValidationResult validateContent(string theContent)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };
            aResult.IsValid = theContent.Length > 10 && theContent.Length <= 10000;
            aResult.Message = !aResult.IsValid ? "The content must be between 10 and 10000 characters" : "";

            return aResult;
        }
        public EntityValidationResult validateWrittenDate(DateTime writtenDate)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };
            aResult.IsValid = DateTime.Compare(writtenDate, DateTime.Now) <= 0;
            aResult.Message = !aResult.IsValid ? "The date is not valid" : "";

            return aResult;
        }
        public EntityValidationResult validateModifiedDate(DateTime modifiedDate)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };
            aResult.IsValid = DateTime.Compare(modifiedDate, DateTime.Now) <= 0;
            aResult.Message = !aResult.IsValid ? "The date is not valid" : "";

            return aResult;
        }

    }
}
