using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JobberGuys.Models;

namespace JobberGuys.ViewModels
{
    public class RandomJobViewModel
    {
        public Job Job { get; set; }
        public List<Applicant> Applicants;
    }
}