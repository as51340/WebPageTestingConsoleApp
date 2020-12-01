using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageTest.Request
{
    public class RequestObject
    {
        public string baseUrl { get; set; }
        public string pageUrl { get; set; }
        public string category { get; set; }
        public string locale { get; set; }
        public string strategy { get; set; }
        public string utm_campaign { get; set; }
        public string utm_source { get; set; }
        public string captchaToken { get; set; }
        public string apiKey { get; set; }

        public override string ToString()
        {
            apiKey = " AIzaSyDkLP18qfc7EodkeSk_PZROUpKaUfXDsOc "; //api key is hard-coded
            string finalUrl = baseUrl;
            finalUrl = append(finalUrl, "?url=", pageUrl);
            finalUrl = append(finalUrl, "&category=", category);
            finalUrl = append(finalUrl, "&locale=", locale);
            finalUrl = append(finalUrl, "&strategy=", strategy);
            finalUrl = append(finalUrl, "&utm_campaign", utm_campaign);
            finalUrl = append(finalUrl, "&utm_source", utm_source);
            finalUrl = append(finalUrl, "&captchaToken=", captchaToken);
            finalUrl = append(finalUrl, "&key=", apiKey);
            return finalUrl;
        }

        private string append(string finalUrl, string key, string value)
        {
            if(string.IsNullOrEmpty(value) == false)
            {
                finalUrl = String.Concat(finalUrl, key, value);
            }
            return finalUrl;
        }
    }
}
