using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobberGuys.Models;
using JobberGuys.ViewModels;

namespace JobberGuys.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult RandomJobs()
        {
            var job = new Job() { Title = "Web Developer" };
            var applicants = new List<Applicant>
            {
                new Applicant {FirstName = "Applicant 1"},
                new Applicant {FirstName = "Applicant 2"}
            };

            var viewModel = new RandomJobViewModel
            {
                Job = job,
                Applicants = applicants

            };
            return View(viewModel);
        }
    }
}