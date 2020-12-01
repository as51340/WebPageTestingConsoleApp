using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageTest.Response.ResponseSubobjects.Performance
{
    public class PerformanceItem
    {
        public double score { get; set; }
        public Node node { get; set; }
        public string timingType { get; set; }
        public string name { get; set; }
        public double startTime { get; set; }
        public string url { get; set; }
        public string label { get; set; }
        public int wastedMs { get; set; }
    }
}
