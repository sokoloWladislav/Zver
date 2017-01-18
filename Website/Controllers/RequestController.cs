using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuisnessLogicLevel.Interfaces;
using BuisnessLogicLevel.Servicies;
using Models.Entities;

namespace Website.Controllers
{
    [Authorize]
    public class RequestController : Controller
    {
        private IRequestService requestService;

        public RequestController(IRequestService service)
        {
            requestService = service;
        }

        public ActionResult Index()
        {
            var requests = requestService.GetAllRequests();
            return View(requests);
        }

        public ActionResult DeleteRequest(int id)
        {
            requestService.DeleteRequest(id);
            return RedirectToAction("Index");
        }
    }
}
