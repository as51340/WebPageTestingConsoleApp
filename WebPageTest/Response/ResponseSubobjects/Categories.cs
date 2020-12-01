using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageTest.Response.ResponseSubobjects
{
    public class Categories
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string score { get; set; }
        public string manualDescription { get; set; }
        public AuditRef[] auditRefs { get; set; }
    }
}
