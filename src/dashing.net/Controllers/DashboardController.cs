﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace dashing.net.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Sampletv()
        {
            return View("Sample");
        }

        public ActionResult Sample()
        {
            return View();
        }
    }
}
