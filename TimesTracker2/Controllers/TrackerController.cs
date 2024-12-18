using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TimesTracker2.Data;
using TimesTracker2.Models;
using TimesTracker2.Services.Interfaces;

namespace TimesTracker2.Controllers
{
    public class TrackerController : Controller
    {
        private readonly ITracker _tracker;

        public TrackerController(ITracker tracker)
        {
            _tracker = tracker;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetProjects()
        {
            var projects = await _tracker.GetProjects();

            var model = new List<SelectListItem>();

            model.Add(new SelectListItem { Text = "Select project", Value = "" });

            foreach (var project in projects)
            {
                model.Add(new SelectListItem { Text = project.ProjectName, Value = project.ProjectId.ToString() });
            }


            return PartialView("~/Views/Tracker/_ProjectsPartial.cshtml", model);
        }

        public async Task<IActionResult> GetProjectInfo(int projectId)
        {
            var test = await _tracker.GetProject(projectId);

            return PartialView("~/Views/Tracker/_ProjectInfoPartial.cshtml", test);
        }

        public ActionResult AddTrackingTime(AddTimeDto addTime)
        {
            var test = _tracker.AddTime(addTime);
            return Ok(test);
        }

        public ActionResult AddProject(AddProject addProject)
        {
            var test = _tracker.AddProject(addProject);
            return Ok(test);
        }

        public ActionResult RemoveProject(DeleteProject deleteProject)
        {
            var test = _tracker.DeleteProject(deleteProject);
            return Ok(test);
        }

        public ActionResult CompleteProject(CompleteProject completeProject)
        {
            var test = _tracker.CompleteProject(completeProject);
            return Ok(test);
        }


        }
        //return PartialViewResult("~/Views/Tracker/_ProjectsPartial", test);
    }
