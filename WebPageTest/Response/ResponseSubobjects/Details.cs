using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using WebPageTest.Response.ResponseSubobjects.Performance;

namespace WebPageTest.Response.ResponseSubobjects
{
    public class Details
    {
        public Heading[] headings { get; set; }
        [JsonPropertyName("items")]
        public Dictionary<string, Node>[] items { get; set; }
        [JsonPropertyName("items")]
        public PerformanceItem[] perfItems { get; set; }
        public string table { get; set; }
        public string snippet { get; set; }
        public int overallSavingsMs { get; set; }
        public string type { get; set; }
    }
}
