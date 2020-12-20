using NewYearCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewYearCard.Controllers
{
    public class HomeController : Controller
    {
        NoelCardContext db = new NoelCardContext();
        public ActionResult Index()
        {
            return View(db.Cards.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Your creation of card description page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Card card)
        {
            if (ModelState.IsValid)
            {
                db.Cards.Add(card);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            else
            {
                return View();
            }

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}