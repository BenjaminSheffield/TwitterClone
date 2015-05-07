using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwitterClone.Models;

namespace TwitterClone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            if (User.Identity.IsAuthenticated)
            {
                ApplicationDbContext Db = new ApplicationDbContext();

                var viewModel = new HubIndexViewModel
                {
                    TweetsViewModel = new ListTweetsViewModel
                    {
                        Tweets = Db.Tweets.ToList()
                    }
                };

                return RedirectToAction("Index", "Hub", viewModel);
            }
            else
            {
                return View(); 
            }
        
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}