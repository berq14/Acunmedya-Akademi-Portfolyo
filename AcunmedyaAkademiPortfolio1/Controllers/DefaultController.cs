using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio1.Models;
namespace AcunmedyaAkademiPortfolio1.Controllers
{
    public class DefaultController : Controller
    {
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();

            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialStatistics()
        {
            var values = db.TblStats.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialExperience()
        {
            var values = db.TblExperience.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialEducation()
        {
            var values = db.TblEducation.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialPortfolio()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }  
        public PartialViewResult PartialContact()
        {
            var values = db.TblMessage.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServices()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialTestimonials()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialFooter()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialHeroSection()
        {
            var values = db.TblSocialMedia.ToList();

            return PartialView(values);
        }

        [HttpPost]
        public ActionResult CreateMessage(TblMessage Message)
        {
            Message.Status = true;
            db.TblMessage.Add(Message);
           
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}