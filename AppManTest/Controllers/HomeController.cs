using AppManTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppManTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Bingo(int[] value)
        {
            var result = new Bingo().CheckBingo(value);
            return Json(result);
        }

        [HttpPost]
        public JsonResult Calculation(string expression)
        {
            var result = new Calculation().Cal(expression);
            return Json(result);
        }

    }
}