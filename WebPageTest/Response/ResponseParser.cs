using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using WebPageTest.Request;

namespace WebPageTest.Response
{
    public class ResponseParser
    {

        private string apiResponse;

        public ResponseParser(string apiResponse)
        {
            this.apiResponse = apiResponse;
        }
        public void HandleDeserializationError(object sender, ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }
        public ResponseObject CreateResponseObject()
        {
            ResponseObject responseObject = (ResponseObject)JsonConvert.DeserializeObject<ResponseObject>(apiResponse, new JsonSerializerSettings
            {
                Error = HandleDeserializationError
            });
            //Console.WriteLine(responseObject.id);
            /*dynamic dObject = JsonConvert.DeserializeObject(apiResponse);
            ResponseObject responseObject = new ResponseObject();
            if(readMethod("CaptchaResult") == true)
            {
                responseObject.captchaResult = dObject.captchaResult;
            }
            if(readMethod("Kind") == true)
            {
                responseObject.kind = dObject.kind;
            }
            if(readMethod("id") == true)
            {
                responseObject.id = dObject.id;
            }
            if(readMethod("analysisUTCTimestamp") == true)
            {
                responseObject.analysisUTCTimestamp = dObject.analysisUTCTimestamp;
            }
            if(readMethod("version.major") == true)
            {
                responseObject.version.major = dObject.version.major;
            }
            if(readMethod("version.minor") == true)
            {
                responseObject.version.minor = dObject.version.minor;
            }
            if (readMethod("loadingExperience.id") == true)
            {
                responseObject.loadingExperience.id = dObject.loadingExperience.id;
            }
            if (readMethod("") == true)
            {
                responseObject. = dObject.;
            }
            if (readMethod("") == true)
            {
                responseObject. = dObject.;
            }
            if (readMethod("") == true)
            {
                responseObject. = dObject.;
            }
            if (readMethod("") == true)
            {
                responseObject. = dObject.;
            }
            if (readMethod("") == true)
            {
                responseObject. = dObject.;
            }
            if (readMethod("") == true)
            {
                responseObject. = dObject.;
            }

            Console.WriteLine("Captcha " + responseObject.captchaResult);*/
            return null;
        }

        private Boolean readMethod(string property)
        {
            Console.Write("\nDo you want to include" + property + " in your response: Y/N: ");
            string answer = Console.ReadLine();
            return answer.ToUpper().Equals("Y");
        }


    }
}
