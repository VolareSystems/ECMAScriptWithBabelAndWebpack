﻿using System.Web.Mvc;

namespace ECMAScriptWithBabelAndWebpack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {
            return View();
        }
    }
}