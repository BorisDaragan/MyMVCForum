using MyMVCForum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace MyMVCForum.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //
        // GET: /Forum/
        public ActionResult Index()
        {
            return View(db.Topics.ToList());
        }

        // GET: /Topic/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Topic/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TopicID,TopicName")] Topic topic)
        {
            if (ModelState.IsValid)
            {
                topic.AuthorTopicId = User.Identity.GetUserId();
                db.Topics.Add(topic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(topic);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
	}
}