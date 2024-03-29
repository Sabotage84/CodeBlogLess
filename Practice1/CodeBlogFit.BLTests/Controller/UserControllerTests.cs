﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeBlogFit.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFit.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void UserControllerTest()
        {
            UserController uc = new UserController("LADA");
            Assert.IsNotNull(uc);

        }

        [TestMethod()]
        public void UserControllerTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]//Done 
        public void SaveTest()
        {
            // Arrange
            var userName = Guid.NewGuid().ToString();

            // Act
            var controller = new UserController(userName);

            // Assert 
            Assert.AreEqual(userName, controller.CurrentUser.Name);
          
        }

        [TestMethod()]
        public void SetNewUserDataTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();
            var birthDate = DateTime.Now.AddYears(-18);
            var weight = 90;
            var height = 190;
            var gender = "man";
            var controller = new UserController(userName);

            //Act
            controller.SetNewUserData(gender,birthDate,weight,height);
            var controller2 = new UserController(userName);

            //Assert
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.ToString());
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(birthDate, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
        }

        [TestMethod()]
        public void TestSowTest()
        {
            UserController uc = new UserController("Ivan");
            uc.TestSow();
            Assert.IsNotNull(uc);
        }

        [TestMethod()]
        public void TestShowAllTest()
        {
            UserController uc = new UserController("Ivan");
            uc.TestShowAll();
            Assert.AreEqual(true, true);
        }
    }
}
