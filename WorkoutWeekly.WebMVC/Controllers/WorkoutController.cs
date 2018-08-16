using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkoutWeekly.Models;
using WorkoutWeekly.Services;

namespace WorkoutWeekly.WebMVC.Controllers
{
    [Authorize]
    public class WorkoutController : Controller
    {
        // GET: Yoga
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkoutService(userId);
            var model = service.GetWorkouts();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkoutCreate model)
        {
            if (!ModelState.IsValid) return View(model);

            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkoutService(userId);

            service.CreateWorkout(model);

            return RedirectToAction("Index");
        }
    }
}