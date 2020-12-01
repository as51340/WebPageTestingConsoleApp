using System;
using System.Collections.Generic;
using System.Text;
using WebPageTest.Response.ResponseSubobjects;

namespace WebPageTest.Response
{
    public class ResponseObject
    {
        public string captchaResult { get; set; }
        public string kind { get; set; }
        public string id { get; set; }
        public LoadingExperience loadingExperience { get; set; }
        public LoadingExperience originLoadingExperience { get; set; }
        public LighthouseResult lighthouseResult { get; set; }
        public string analysisUTCTimestamp { get; set; }
        public ResponseSubobjects.Version version { get; set; }

    }
}
