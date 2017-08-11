using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {
        //Private instance of the database
        private ApplicationDbContext db = new ApplicationDbContext();
        //Index
        public IActionResult Index()
        {
            return View();
        }
    public IActionResult Subscribe()
        {
            return View();
        }
    }
}