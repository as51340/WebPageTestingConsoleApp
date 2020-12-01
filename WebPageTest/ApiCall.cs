using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebPageTest.Request;

namespace WebPageTest
{
    public class ApiCall
    {
        public static async Task<string> callApiAsync(RequestObject requestObject)
        {
            string requestString = requestObject.ToString();
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(requestString))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        System.IO.File.WriteAllText("output.json", data);
                        return data;
                    }
                }
            }
        }
    }
}
