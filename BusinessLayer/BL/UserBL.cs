using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BL
{
    public class UserBL : EntityBL<User>
    {
        private UserBL() { }
        private static UserBL _instance;
        public static UserBL GetInstance()
        {
            if (_instance == null)
                _instance = new UserBL();

            return _instance;
        }
    }
}
