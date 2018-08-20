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

            if (service.CreateWorkoutType(model))
            {
                TempData["SaveResult"] = "New Exercise Type created.";
                return RedirectToAction("Index");
            };

            ModelState.AddModelError("", "Exercise Type could not be created");
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var svc = CreateWorkoutTypeService();
            var model = svc.GetWorkoutTypeById(id);

            return View(model);
        }

        public ActionResult Edit (int id)
        {
            var service = CreateWorkoutTypeService();
            var detail = service.GetWorkoutTypeById(id);
            var model =
                new WorkoutTypeEdit
                {
                    WorkoutTypeId = detail.WorkoutTypeId,
                    Type = detail.Type
                };
            return View(model);
        }

        private WorkoutTypeService CreateWorkoutTypeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new WorkoutTypeService(userId);
            return service;
        }
    }
}