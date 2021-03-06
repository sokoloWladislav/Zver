﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using BuisnessLogicLevel.Interfaces;
using BuisnessLogicLevel.Servicies;
using Models.Entities;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private IRequestService requestService;

        public HomeController(IRequestService service)
        {
            requestService = service;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateRequest(Request model)
        {
            requestService.CreateRequest(model);
            return new EmptyResult();
        }

    }
}
