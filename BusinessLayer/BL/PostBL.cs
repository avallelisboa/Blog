using BusinessLayer.DTOs;
using BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.BL
{
    public class PostBL : EntityBL<Post>
    {
        private PostBL() { }
        private static PostBL _instance;
        public static PostBL GetInstance()
        {
            if (_instance == null)
                _instance = new PostBL();

            return _instance;
        }
    }
}
