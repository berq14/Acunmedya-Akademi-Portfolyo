using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio1.Models;

namespace AcunmedyaAkademiPortfolio1.Controllers
{
    public class MessageController : Controller
    {
        public class MessagesController : Controller
        {
            // GET: Messages
            DbAcunmedyaAkademi1Entities db = new DbAcunmedyaAkademi1Entities();
            public ActionResult MessageList()
            {

                var values = db.TblMessage.ToList();
                return View(values);
            }

            [HttpGet]
            public ActionResult CreateMessage()
            {
                return View();
            }

            [HttpPost]
            public ActionResult CreateMessage(TblMessage Message)
            {

                db.TblMessage.Add(Message);
                db.SaveChanges();
                return RedirectToAction("MessageList");
            }

            public ActionResult DeleteMessage(int id)
            {
                var value = db.TblMessage.Find(id);
                db.TblMessage.Remove(value);
                db.SaveChanges();
                return RedirectToAction("MessageList");
            }

            [HttpGet]

            public ActionResult UpdateMessage(int id)
            {
                var value = db.TblMessage.Find(id);
                return View(value);
            }

            [HttpPost]
            public ActionResult UpdateMessage(TblMessage p)
            {

                var value = db.TblMessage.Find(p.MessageId);

                value.SenderName = p.SenderName;
                value.SenderEmail= p.SenderEmail;
                value.Subject= p.SenderEmail;
                value.Detail= p.Detail;
                value.Status= p.Status;
                db.SaveChanges();
                return RedirectToAction("MessageList");
            }
        }
    }
}