using BusinessLayer.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private IWootService _wootService;
        public HomeController(IWootService wootService)
        {
            _wootService = wootService;
        }
        public ActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                var response = _wootService.GetWootById(id.Value);
            }
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
    }
}