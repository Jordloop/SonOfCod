using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
    public class NewsletterController : Controller
    {
        //Private instance of the database
        private ApplicationDbContext db = new ApplicationDbContext();
        //Index
        public IActionResult Index()
        {
            return View();
        }
        //Subscribe
        public IActionResult Subscribe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Subscribe(Subscriber subscriber)
        {
            db.Subscribers.Add(subscriber);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
