﻿using MonaLisaWebApi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonaLisaWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();
            var products = db.Products.ToList()[0];

            ViewBag.Title = products.ProductName;

            return View();
        }
    }
}
