﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EchangeDeLivres.Models;
using System.Globalization;

namespace EchangeDeLivres.Controllers


{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ChangeLanguage(string linkBack, string languageCode)
        {
            Session["LanguageChoice"] = new CultureInfo(languageCode);

            return Redirect(linkBack);
        }
    }
}