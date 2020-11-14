using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobberGuys.Models;

namespace JobberGuys.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult Jobs()
        {
            var job = new Job() { Title = "Web Developer" };
            return View(job);
        }
    }
}