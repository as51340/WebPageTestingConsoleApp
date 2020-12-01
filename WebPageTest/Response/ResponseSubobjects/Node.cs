using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageTest.Response.ResponseSubobjects
{
    public class Node
    {
        public string path { get; set; }
        public string explanation { get; set; }
        public string nodeLabel { get; set; }
        public string type { get; set; }
        public BoundingRect boundingRect { get; set; }
        public string selector { get; set; }
    }
}
