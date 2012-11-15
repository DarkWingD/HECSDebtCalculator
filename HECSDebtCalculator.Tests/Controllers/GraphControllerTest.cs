using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HECSDebtCalculator;
using HECSDebtCalculator.Controllers;

namespace HECSDebtCalculator.Tests.Controllers
{
    [TestClass]
    public class GraphControllerTest
    {
        [TestMethod]
        public void returnUserHecsPrediction()
        {
            // Arrange
            GraphController controller = new GraphController();

            // Act
            ViewResult result = null;// controller.returnUsersHecsPrediction as ViewResult;

            // Assert
            Assert.AreEqual("Modify this template to jump-start your ASP.NET MVC application.", result.ViewBag.Message);
        }
    }
}
