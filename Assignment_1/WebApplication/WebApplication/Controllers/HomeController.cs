using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        Repository repository = new Repository();
        public ActionResult Index()
        {
            var result = repository.GetAllLeageDetails();
            var filter = result.Where(x => x.Status == "Win" || x.Status == "WIN");
            return View("LeagueDetails", filter);
        }
    }
}