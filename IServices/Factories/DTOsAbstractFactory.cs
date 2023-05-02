using BusinessLayer.Entities;
using IServices.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.Factories
{
    public abstract class DTOsAbstractFactory
    {
        public abstract ActionResult makeValidDTO(Entity theEntity);
        public ActionResult makeInvalidDTO(string errorMessage)
        {
            return new ActionResult
            {
                isValid = false,
                message = errorMessage
            };
        }
        public ActionResult makeInvalidDTO(Exception ex)
        {
            return new ActionResult
            {
                isValid = false,
                message = ex.Message
            };
        }
    }
}
