using IServices.DTOs.Request.Session;
using IServices.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.IServices
{
    public interface ISessionService
    {
        ActionResult login(LoginRequest theRequest);
        ActionResult register(RegisterRequest theRequest);
    }
}
