using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCcourse8.Models
{
    public class ProjectEvaluation
    {
        public string name;
        public string city;
        public string country;
        public double rating;
        public static List<ProjectEvaluation> ProjectEvaluations { get; set; }
    }
}