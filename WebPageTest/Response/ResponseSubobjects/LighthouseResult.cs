using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageTest.Response.ResponseSubobjects
{
    public class LighthouseResult
    {
        public string requestedUrl { get; set; }
        public string finalUrl { get; set; }
        public string lighthouseVersion { get; set; }
        public string userAgent { get; set; }
        public string fetchTime { get; set; }
        public Environment environment { get; set; }
        public string[] runWarnings { get; set; }
        public ConfigSettings configSettings { get; set; }
        public Dictionary<string, Audits> audits { get; set; }
        public Dictionary<string, Categories> categories { get; set; }
        public Dictionary<string, CategoryGroup> categoryGroups { get; set; }
        public RuntimeError runtimeError { get; set; }
        public Timing timing { get; set; }
        public I18n i18n { get; set; }
    }
}
