﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio1.Models;

namespace AcunmedyaAkademiPortfolio1.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Projects
        DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
        public ActionResult ProjectList()
        {

            var values = db.TblProject.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(TblProject Project)
        {

            db.TblProject.Add(Project);
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }

        public ActionResult DeleteProject(int id)
        {
            var value = db.TblProject.Find(id);
            db.TblProject.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }

        [HttpGet]

        public ActionResult UpdateProject(int id)
        {
            var value = db.TblProject.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {

            var value = db.TblProject.Find(p.ProjectId);

            value.ProjectTitle = p.ProjectTitle;
            value.Description = p.Description;
            value.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}