using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio1.Models;

namespace AcunmedyaAkademiPortfolio1.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
        public ActionResult AboutControllerList()
        {

            var values = db.TblAbout.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(TblAbout About)
        {

            db.TblAbout.Add(About);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            db.TblAbout.Remove(value);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]

        public ActionResult UpdateAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }

        //[HttpPost]
        //public ActionResult UpdateCategory(TblAbout p)
        //{

        //    var value = db.TblAbout.Find(p.AboutId);

        //    value.CategoryName = p.CategoryName;
        //    return View(value);
        //}
    }
}

