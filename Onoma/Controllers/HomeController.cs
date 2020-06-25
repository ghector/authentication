using Onoma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Onoma.Controllers
{

    public class HomeController : Controller
    {


        [Authorize(Roles = RoleName.Administrators + "," + RoleName.Spectators)] //Problima
        public ActionResult Index()
        {

            return View();
        }

        [Authorize(Users = "Mponatsos2@gmail.com,Mitsos@gmail.com")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize(Users = "Mponatsos2@gmail.com")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        [Authorize(Roles = RoleName.Administrators)]
        [Authorize(Roles = RoleName.Spectators)]
        public ActionResult Contact223()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}