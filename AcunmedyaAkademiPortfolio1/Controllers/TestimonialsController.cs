using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio1.Models;

namespace AcunmedyaAkademiPortfolio1.Controllers
{
    public class TestimonialsController : Controller
    {
        // GET: Testimonials
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
        public ActionResult TestimonialList()
        {

            var values = db.TblTestimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial Testimonial)
        {

            db.TblTestimonial.Add(Testimonial);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]

        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial p)
        {

            var value = db.TblTestimonial.Find(p.TestimonialId);

            value.NameSurname = p.NameSurname;
            value.Title = p.Title;
            value.CommentDetail = p.CommentDetail;
            value.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}