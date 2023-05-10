using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.BL;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    public class UserTest
    {
        [Test]
        public void ValidateUsernameLength_ValidUsername_ReturnsTrue()
        {
            string username = "john_doe";
            bool expected = true;
            bool actual = UserBL.GetInstance().validateUserName(username).IsValid;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateUsernameLength_InvalidUsername_ReturnsFalse()
        {
            string username = "j";
            bool expected = false;
            bool actual = UserBL.GetInstance().validateUserName(username).IsValid;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateEmail_ValidEmail_ReturnsTrue()
        {
            string email = "test@example.com";
            bool expected = true;
            bool actual = UserBL.GetInstance().validateEmail(email).IsValid;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ValidateEmail_InvalidEmail_ReturnsFalse()
        {
            string email = "invalid_email";
            bool expected = false;
            bool actual = UserBL.GetInstance().validateEmail(email).IsValid;
            Assert.AreEqual(expected, actual);
        }
    }
}
