using NewYearCard.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewYearCard.Controllers
{
    public class CardController : Controller
    {
        private NoelCardContext db;
        // GET: Card
        public ActionResult Edit(int? id)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }
            else
            {
                using (db = new NoelCardContext())
                {
                    Card editedCard = db.Cards.Find(id);
                    return View(editedCard);
                }
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Card card)
        {
            if (card == null)
            {
                return HttpNotFound();
            }
            else
            {
                using (db = new NoelCardContext())
                {
                    db.Entry(card).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }
            else
            {
                using (db = new NoelCardContext())
                {
                    Card deletedCard = db.Cards.Find(id);
                    return View(deletedCard);
                }
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(Card card)
        {
            if (card == null)
            {
                return HttpNotFound();
            }
            else
            {
                using (db = new NoelCardContext())
                {
                    db.Entry(card).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Download(int? id)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }
            else
            {
                using (db = new NoelCardContext())
                {
                    Card downloadedCard = db.Cards.Find(id);
                    return View(downloadedCard);
                }
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Download(Card card)
        {
            if (card == null)
            {
                return HttpNotFound();
            }
            else
            {
                using (db = new NoelCardContext())
                {
                    db.Entry(card).State = EntityState.Unchanged;
                }
                return RedirectToAction("Download","Card");
            }
        }

        public ActionResult ViewCard(int? id)
        {
            if (id == 0)
            {
                return HttpNotFound();
            }
            else
            {
                using (db = new NoelCardContext())
                {
                    Card viewedCard = db.Cards.Find(id);
                    return View(viewedCard);
                }
            }
        }


    }
}