using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace HECSDebtCalculator.Controllers
{
    public class GraphController: Controller
    {
        public ActionResult UsersHecsPrediction()
        {
            //var userName = User.Identity.Name;

            //var userId = WebSecurity.CurrentUserId;
            //var userName2 = WebSecurity.CurrentUserName;

            var model = new Models.HecsPredictionModel();

            model.SomeValues = new List<decimal> { 123, 456, 789 };

            return View(model);
        }

        public class Foo
        {
            public string Name { get; set; }
        }

        [HttpPost]
        public ActionResult UsersHecsPrediction(Foo someFoo)
        {
            //var userName = User.Identity.Name;

            //var userId = WebSecurity.CurrentUserId;
            //var userName2 = WebSecurity.CurrentUserName;

            var model = new Models.HecsPredictionModel();

            model.SomeValues = new List<decimal> { 123, 456, 789 };

            return View(model);
        }
    }
}