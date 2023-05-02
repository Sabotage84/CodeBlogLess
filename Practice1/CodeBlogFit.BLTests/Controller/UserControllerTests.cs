using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod()]
        public void SaveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetNewUserDataTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TestSowTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TestShowAllTest()
        {
            Assert.Fail();
        }
    }
}