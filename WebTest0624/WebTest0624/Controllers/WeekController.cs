using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest0624.Controllers
{
    public class WeekController : Controller
    {
        // GET: Week
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(float number)
        {
            var result = "";
            if (number == 1)
                result = "星期一";
            if (number == 2)
                result = "星期二";
            if (number == 3)
                result = "星期三";
            if (number == 4)
                result = "星期四";
            if (number == 5)
                result = "星期五";
            if (number == 6)
                result = "星期六";
            if (number == 7)
                result = "星期日";

            ViewBag.Result = result;
            return View();
        }
    }
}