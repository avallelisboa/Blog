using BusinessLayer.BL;
using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Strategies
{ 
    public class UserStrategyValidator : IEntityStrategyValidator
    {
        public void Validate(Entity theEntity)
        {
            var userBL = UserBL.GetInstance();
            var user = (User)theEntity;

            user.AddValidationResult(userBL.validateId(user.Id));
            user.AddValidationResult(userBL.validateUserName(user.UserName));
            user.AddValidationResult(userBL.validateName(user.Name));
            user.AddValidationResult(userBL.validateLastName(user.LastName));
            user.AddValidationResult(userBL.validatePassword(user.Password));
        }
    }
}
