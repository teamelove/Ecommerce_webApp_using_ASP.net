﻿using Ecommerce.Models;
using Ecommerce.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ecommerce.DAL;
using Ecommerce.Repository;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string search)
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            return View(model.CreateModel(search));
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
    }
}