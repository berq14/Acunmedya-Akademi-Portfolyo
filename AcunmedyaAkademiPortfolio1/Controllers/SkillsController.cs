using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio1.Models;

namespace AcunmedyaAkademiPortfolio1.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
        public ActionResult SkillList()
        {

            var values = db.TblSkill.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(TblSkill Skill)
        {

            db.TblSkill.Add(Skill);
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            db.TblSkill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]

        public ActionResult UpdateSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateSkill(TblSkill p)
        {

            var value = db.TblSkill.Find(p.SkillId);

            value.SkillValue = p.SkillValue;
            value.SkillTitle = p.SkillTitle;
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}