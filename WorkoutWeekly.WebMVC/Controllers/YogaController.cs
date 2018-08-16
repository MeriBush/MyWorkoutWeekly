using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutWeekly.Models;

namespace WorkoutWeekly.WebMVC.Controllers
{
    [Authorize]
    public class YogaController : Controller
    {
        // GET: Yoga
        public ActionResult Index()
        {
            var listItem = new YogaListItem[0];
            return View(listItem);
        }
    }
}