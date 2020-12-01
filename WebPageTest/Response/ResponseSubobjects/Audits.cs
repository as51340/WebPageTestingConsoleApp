using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageTest.Response.ResponseSubobjects
{
    public class Audits
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string score { get; set; }
        public string scoreDisplayMode { get; set; }
        public string displayValue { get; set; }
        public string explanation { get; set; }
        public string errorMessage { get; set; }
        public string warning { get; set; }
        public string[] warnings { get; set; }
        public Details details { get; set; }
        public int numericValue { get; set; }



    }
}
