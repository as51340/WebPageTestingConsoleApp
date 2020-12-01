using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageTest.Response.ResponseSubobjects
{
    public class LoadingExperience
    {
        public string id { get; set; }
        public Dictionary<string, Metrics>  metrics { get; set; }
        public string overall_category { get; set; }
        public string initial_url { get; set; }
    }
}
