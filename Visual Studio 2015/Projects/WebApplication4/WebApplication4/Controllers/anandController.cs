using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class anandController : Controller
    {
        static List<shubham> mm = new List<shubham>();
        public ActionResult Index()
        {
            return View(mm);
        }
        public ActionResult Details(shubham mm)
        {
            return View(mm);
        }
        public ActionResult Create()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(shubham monu)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", monu);
            }
            mm.Add(monu);
            return RedirectToAction("Index");
        }
    }
}