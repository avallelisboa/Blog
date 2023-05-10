using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
            aResult.IsValid = id > 0;
            aResult.Message = !aResult.IsValid ? "The id must be higher than 0" : "";

            return aResult;
        }
        public EntityValidationResult validateUserName(string userName)
        {
           
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };
            int minLength = 4;
            int maxLength = 20;

            if (string.IsNullOrEmpty(userName))
            {
                aResult.IsValid = false;
                aResult.Message= "Username cannot be null or empty.";
                return aResult;
            }

            int usernameLength = userName.Length;

            if (usernameLength < minLength || usernameLength > maxLength)
            {
                aResult.IsValid = false;
                aResult.Message = $"Username length should be between {minLength} and {maxLength} characters.";
                return aResult;
            }

            aResult.IsValid = true;
            return aResult;
        }
        public EntityValidationResult validatePassword(string thePassword)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };
            aResult.IsValid = thePassword.Length >= 9 && thePassword.Length <= 50;
            aResult.Message = !aResult.IsValid ? "The password must be between 9 and 50 characters" : "";
            return aResult;
        }
        public EntityValidationResult validateEmail(string email)
        {
            int maxLength = 50;
            int minLength = 10;
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = true,
                Message = ""
            };
            if (string.IsNullOrEmpty(email))
            {
                aResult.IsValid = false;
                aResult.Message = "Email address cannot be null or empty.";
            }

            if (email.Length > maxLength || email.Length < minLength)
            {
                aResult.IsValid = false;
                aResult.Message = $"Email length must be between {minLength} and {maxLength} characters.";
            }

            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                aResult.IsValid = false;
                aResult.Message = "Invalid email address format.";
            }

            return aResult;
        }
        public EntityValidationResult validateName(string theName)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };
            int minLength = 4;
            int maxLength = 15;

            if (string.IsNullOrEmpty(theName))
            {
                aResult.IsValid = false;
                aResult.Message = "The name cannot be null or empty.";
                return aResult;
            }

            int usernameLength = theName.Length;

            if (usernameLength < minLength || usernameLength > maxLength)
            {
                aResult.IsValid = false;
                aResult.Message = $"Name length should be between {minLength} and {maxLength} characters.";
                return aResult;
            }

            aResult.IsValid = true;
            return aResult;
        }
        public EntityValidationResult validateLastName(string theLastName)
        {
            EntityValidationResult aResult = new EntityValidationResult
            {
                IsValid = false,
                Message = ""
            };

            int minLength = 4;
            int maxLength = 20;

            if (string.IsNullOrEmpty(theLastName))
            {
                aResult.IsValid = false;
                aResult.Message = "Username cannot be null or empty.";
                return aResult;
            }

            int LastNameLength = theLastName.Length;

            if (LastNameLength < minLength || LastNameLength > maxLength)
            {
                aResult.IsValid = false;
                aResult.Message = $"Lastname length should be between {minLength} and {maxLength} characters.";
                return aResult;
            }

            aResult.IsValid = true;

            return aResult;
        }
    }
}
