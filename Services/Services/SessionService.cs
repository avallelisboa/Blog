using BusinessLayer.BL;
using BusinessLayer.Entities;
using BusinessLayer.Factories;
using IDataAccess.IDAOs;
using IServices.DTOs.Request.Session;
using IServices.DTOs.Response;
using IServices.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class SessionService : ISessionService
    {
        private readonly IUserDAO _userDAO;
        public SessionService(IUserDAO theUserDAO)
        {
            _userDAO = theUserDAO;
        }
        public ActionResult login(LoginRequest theRequest)
        {
            throw new NotImplementedException();
        }

        public ActionResult register(RegisterRequest theRequest)
        {
            ActionResult result = new ActionResult();
            User user = new User(theRequest.userName, theRequest.email, theRequest.name, theRequest.lastName, theRequest.password, theRequest.role);
            var validationResult = UserBL.GetInstance().IsValid(user);
            if (!validationResult.IsValid)
            {
                result.isValid = validationResult.IsValid;
                result.message = validationResult.Message;
                return result;
            }
            try
            {
                _userDAO.Add(DBObjectFactoryMethods.makeUserDB(user));
            }catch(Exception ex)
            {
                result.isValid = false;
                result.message = ex.Message;
                return result;
            }
            result.message = "The user was registered correctly";
            return result;
        }
    }
}
