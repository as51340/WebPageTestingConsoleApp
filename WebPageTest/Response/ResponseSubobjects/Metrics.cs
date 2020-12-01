using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageTest.Response.ResponseSubobjects
{
    public class Metrics
    {
        public int percentile { get; set; }
        public Distribution[] distributions { get; set; }
        public string category { get; set; }
    }
}
