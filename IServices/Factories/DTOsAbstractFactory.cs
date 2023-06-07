using BusinessLayer.Entities;
using IDataAccess.DBObjects;
using IServices.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace IServices.Factories
{
    public abstract class DTOsAbstractFactory
    {
        public abstract ActionResult makeValidDTO(Entity theEntity);
        public abstract ActionResult makeValidDTO(DBObject theDBObject);
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
