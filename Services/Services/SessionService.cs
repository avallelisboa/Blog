﻿using IServices.DTOs.Request.Session;
using IServices.DTOs.Response;
using IServices.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class SessionService : ISessionService
    {
        public ActionResult login(LoginRequest theRequest)
        {
            throw new NotImplementedException();
        }

        public ActionResult register(RegisterRequest theRequest)
        {
            throw new NotImplementedException();
        }
    }
}