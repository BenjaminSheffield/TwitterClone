using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterClone.Models;

namespace TwitterClone.Controllers
{
    public class HubController : Controller
    {
        // GET: Hub
        public ActionResult Index()
        {
            ApplicationDbContext Db = new ApplicationDbContext();

            return View(Db.Tweets.ToList());

            //if (User.Identity.IsAuthenticated)
            //{
            //    return View();  //Db.Users.ToList()
            //}
            //else
            //{
            //    return RedirectToAction("Login", "Account");
            //}
        }

        [HttpPost]
        public ActionResult CreateTweet(SubmitTweetViewModel model)
        {
            //grab values from ViewModel and save particular parts to db
            ApplicationDbContext Db = new ApplicationDbContext();

            Db.Tweets.Add(new Tweet {Content = model.Content, User = model.User});
            Db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Hub/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Hub/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hub/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hub/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Hub/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Hub/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Hub/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
