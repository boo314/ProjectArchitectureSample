using BusinessLayer.Exceptions;
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
                try
                {
                    var response = _wootService.GetWootById(id.Value);
                }
                catch (WootException ex)
                {
                    ViewBag.ErrorMessage = ex.Message;
                }
                
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