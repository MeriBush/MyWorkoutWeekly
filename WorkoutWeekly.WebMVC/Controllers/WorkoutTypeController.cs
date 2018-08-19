using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutWeekly.Models;

namespace WorkoutWeekly.WebMVC.Controllers
{
    [Authorize]
    public class WorkoutTypeController : Controller
    {
        // GET: WorkoutType
        public ActionResult Index()
        {
            var model = new WorkoutTypeListItem[0];
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}