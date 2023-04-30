using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BL
{
    public class UserBL : EntityBL
    {
        private UserBL() { }
        private static UserBL _instance;
        public static UserBL GetInstance()
        {
            if (_instance == null)
                _instance = new UserBL();

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
        public EntityValidationResult validateUserName(string userName)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
        public EntityValidationResult validatePassword(string userName)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
        public EntityValidationResult validateEmail(string userName)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
        public EntityValidationResult validateName(string userName)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
        public EntityValidationResult validateLastName(string userName)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            return aResult;
        }
        public EntityValidationResult validateRole(string userName)
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
