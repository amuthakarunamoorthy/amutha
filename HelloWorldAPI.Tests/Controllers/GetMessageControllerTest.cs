using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;
using HelloWorldAPI.Controllers;

namespace HelloWorldAPI.Tests.Controllers
{
    [TestClass]
    public class GetMessageControllerTest
    {
        [TestMethod]
        public void GetTest_ExactMatch()
        {
            GetMessageController getmessage = new GetMessageController();
            string message = getmessage.GetMessage();
            Assert.AreEqual("Hello World",message);
        }

        [TestMethod]
        public void GetTest_NotEmpty()
        {
            GetMessageController getmessage = new GetMessageController();
            string message = getmessage.GetMessage();
            Assert.IsNotNull(message);
        }
    }
}
