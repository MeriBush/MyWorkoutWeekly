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
    public class WorkoutTypeController : Controller
    {
        // GET: WorkoutType
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkoutTypeService(userId);
            var model = service.GetWorkoutTypes();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WorkoutTypeCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var service = CreateWorkoutTypeService();

            service.CreateWorkoutType(model);
            return RedirectToAction("Index");
        }

        private WorkoutTypeService CreateWorkoutTypeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkoutTypeService(userId);
            return service;
        }
    }
}