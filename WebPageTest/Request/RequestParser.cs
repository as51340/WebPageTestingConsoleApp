using System;
using System.Collections.Generic;
using System.Text;

namespace WebPageTest.Request
{
    public class RequestParser
    {
        public RequestObject createRequest()
        {
            RequestObject requestObject = new RequestObject();
            requestObject.baseUrl = "https://pagespeedonline.googleapis.com/pagespeedonline/v5/runPagespeed";
            requestObject.pageUrl = getUrl();
            requestObject.category = getStrategyCategory("\nEnter category(optional - CATEGORY_UNSPECIFIED, ACCESSIBILITY, BEST_PRACTICES, PERFORMANCE, PWA, SEO): ", false);
            requestObject.locale = readSimpleInput("\nEnter locale(optional): ");
            requestObject.utm_campaign = readSimpleInput("\nEnter utm campaign(optional): ");
            requestObject.utm_source = readSimpleInput("\nEnter utm source(optional): ");
            requestObject.captchaToken = readSimpleInput("\nEnter captcha token(optional): ");
            requestObject.strategy = getStrategyCategory("\nEnter strategy(optional - CATEGORY_UNSPECIFIED, MOBILE, DESKTOP): ", true);
            Console.Write("Url so far: " + requestObject.ToString());
            return requestObject;
        }

        private string getStrategyCategory(string text, bool sc) // if sc == true then we call strategy else category
        {
            Console.Write(text);
            string ret = null;
            while (true)
            {
                ret = Console.ReadLine();
                if (string.IsNullOrEmpty(ret))
                {
                    break;
                }
                bool condition = false;
                if (sc == true)
                {
                    condition = ret.ToUpper().Equals("STRATEGY_UNSPECIFIED") == false && ret.ToUpper().Equals("DESKTOP") == false &&
                    ret.ToUpper().Equals("MOBILE") == false;
                }
                else
                {
                    condition = ret.ToUpper().Equals("CATEGORY_UNSPECIFIED") == false && ret.ToUpper().Equals("ACCESSIBILITY") == false &&
                    ret.ToUpper().Equals("BEST_PRACTICES") == false && ret.ToUpper().Equals("PERFORMANCE") == false &&
                    ret.ToUpper().Equals("PERFORMANCE") == false && ret.ToUpper().Equals("PWA") == false &&
                    ret.ToUpper().Equals("SEO") == false;
                }
                if (condition == true) //check if they entered wrong enum
                {
                    Console.Write("You didn't enter valid strategy, do you want to skip strategy or try again: Y/N ");
                    string resp = Console.ReadLine(); //ask again
                    if (resp.ToUpper().Equals("Y") == true) //if they want to enter again, allow them
                    {
                        Console.Write(text.Substring(1));
                        continue;
                    }
                    else //if not then this parameter won't be used
                    {
                        ret = null;
                        break;
                    }
                }
                else
                {
                    break; // he/she entered valid category/strategy
                }
            }
            return ret;
        }


        private string readSimpleInput(string text) //reads input for utm params, captcha and locale
        {
            Console.Write(text);
            return Console.ReadLine();
        }

        private string getUrl() //gets url of the page, user must enter valid url because it is required params
        {
            Console.Write("Enter url of the website you want to test(required): ");
            string url = null;
            while (true)
            {
                url = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(url))
                {
                    Console.Write("You have to enter valid url: ");
                    //parse url
                    continue;
                }
                else
                {
                    break;
                }
            }
            return url;
        }

        //TODO
        private bool parseUrl() //method for parsing url
        {
            return false;
        }
    }
}

