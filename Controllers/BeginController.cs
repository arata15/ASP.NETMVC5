﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBasic.Models;

namespace MvcBasic.Controllers
{
    public class BeginController : Controller
    {
        private MvcBasicContext db = new MvcBasicContext();

        // GET: Begin
        public ActionResult Index()
        {
            return Content("こんにちは世界！");
        }
        public ActionResult Show()
        {
            ViewBag.Message = "こんにちは、世界！";
            return View();
        }
        public ActionResult List()
        {
            return View(db.Members);
        }
    }
}