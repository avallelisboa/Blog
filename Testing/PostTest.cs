using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.BL;
using BusinessLayer.DTOs;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    public class PostTest
    {
        [Test]
        public void ValidateId_ValidId_ReturnsValidResult()
        {
            PostBL postBL = PostBL.GetInstance();
            int id = 10;
            bool expectedIsValid = true;

            EntityValidationResult actualResult = postBL.validateId(id);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
        }

        [Test]
        public void ValidateId_InvalidId_ReturnsInvalidResult()
        {
            PostBL postBL = PostBL.GetInstance();
            int id = -1;
            bool expectedIsValid = false;

            EntityValidationResult actualResult = postBL.validateId(id);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
        }

        [Test]
        public void ValidateTitle_ValidTitle_ReturnsValidResult()
        {
            PostBL postBL = PostBL.GetInstance();
            string title = "This is a valid title";
            bool expectedIsValid = true;

            EntityValidationResult actualResult = postBL.validateTitle(title);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
        }

        [Test]
        public void ValidateTitle_TooShortTitle_ReturnsInvalidResult()
        {
            PostBL postBL = PostBL.GetInstance();
            string title = "no";
            bool expectedIsValid = false;

            EntityValidationResult actualResult = postBL.validateTitle(title);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
        }

        [Test]
        public void ValidateTitle_TooLongTitle_ReturnsInvalidResult()
        {
            PostBL postBL = PostBL.GetInstance();
            string title = "This title is way too long and should not be accepted";
            bool expectedIsValid = false;

            EntityValidationResult actualResult = postBL.validateTitle(title);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
        }

        [Test]
        public void ValidateContent_ValidContent_ReturnsValidResult()
        {
            PostBL postBL = PostBL.GetInstance();
            string content = "This is a valid content";
            bool expectedIsValid = true;

            EntityValidationResult actualResult = postBL.validateContent(content);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
        }

        [Test]
        public void ValidateContent_TooShortContent_ReturnsInvalidResult()
        {
            PostBL postBL = PostBL.GetInstance();
            string content = "Too short";
            bool expectedIsValid = false;

            EntityValidationResult actualResult = postBL.validateContent(content);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
        }
    }
}
