using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio1.Models;

namespace AcunmedyaAkademiPortfolio1.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
        public ActionResult ServiceList()
        {

            var values = db.TblService.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateService(TblService Service)
        {

            db.TblService.Add(Service);
            db.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public ActionResult DeleteService(int id)
        {
            var value = db.TblService.Find(id);
            db.TblService.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        [HttpGet]

        public ActionResult UpdateService(int id)
        {
            var value = db.TblService.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateService(TblService p)
        {

            var value = db.TblService.Find(p.ServiceId);

            value.IconUrl = p.IconUrl;
            value.Description= p.Description;
            value.ServiceTitle = p.ServiceTitle;
            db.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}