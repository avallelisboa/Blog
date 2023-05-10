using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.BL;
using BusinessLayer.DTOs;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    public class CategoryTest
    {
        [Test]
        public void ValidateId_ValidId_ReturnsValidResult()
        {
            CategoryBL categoryBL = CategoryBL.GetInstance();
            int id = 10;
            bool expectedIsValid = true;
            string expectedMessage = "";

            EntityValidationResult actualResult = categoryBL.validateId(id);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
            Assert.AreEqual(expectedMessage, actualResult.Message);
        }

        [Test]
        public void ValidateId_InvalidId_ReturnsInvalidResult()
        {
            CategoryBL categoryBL = CategoryBL.GetInstance();
            int id = -1;
            bool expectedIsValid = false;
            string expectedMessage = "The id must be higher than 0";

            EntityValidationResult actualResult = categoryBL.validateId(id);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
            Assert.AreEqual(expectedMessage, actualResult.Message);
        }

        [Test]
        public void ValidateName_ValidName_ReturnsValidResult()
        {
            CategoryBL categoryBL = CategoryBL.GetInstance();
            string name = "Category";
            bool expectedIsValid = true;
            string expectedMessage = "";

            EntityValidationResult actualResult = categoryBL.validateName(name);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
            Assert.AreEqual(expectedMessage, actualResult.Message);
        }

        [Test]
        public void ValidateName_InvalidName_ReturnsInvalidResult()
        {
            CategoryBL categoryBL = CategoryBL.GetInstance();
            string name = "A";
            bool expectedIsValid = false;
            string expectedMessage = "The category name must be between 3 and 20 characters";

            EntityValidationResult actualResult = categoryBL.validateName(name);

            Assert.AreEqual(expectedIsValid, actualResult.IsValid);
            Assert.AreEqual(expectedMessage, actualResult.Message);
        }
    }
}
