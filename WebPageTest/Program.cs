using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using WebPageTest.Request;
using WebPageTest.Response;

namespace WebPageTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
           // writeRequestInstructionsToConsole();
            RequestParser requestParser = new RequestParser();
            RequestObject requestObject = requestParser.createRequest();
           string jsonAPIResult = await ApiCall.callApiAsync(requestObject);
            //writeResponseInstructionsToConsole();
            ResponseParser responseParser = new ResponseParser(jsonAPIResult);
            ResponseObject responseObject = responseParser.CreateResponseObject();
        }

        private static void writeResponseInstructionsToConsole()
        {
            Console.Write("\n\nDescription of response parameters, you can specify what parameters you want to include in your response ");
            Console.WriteLine("CaptchaResult: " + "The captcha verify result(CAPTCHA_BLOCKING, CAPTCHA_MATCHED, CAPTCHA_NEEDED, " +
                "CAPTCHA_NOT_NEEDED, CAPTCHA_UNMATCHED)");
            Console.WriteLine("Kind: kind of result");
            Console.WriteLine("Id: Canonicalized and final URL for the document, after following page redirects (if any).");
            Console.WriteLine("loadingExperience: Metrics of end users' page loading experience.");
            Console.WriteLine("loadingExperience.id: The url, pattern or origin which the metrics are on.");
            Console.WriteLine("loadingExperience.metrics: ");
            Console.WriteLine("loadingExperience.metrics.(key): The type of the metric.");
            Console.WriteLine("loadingExperience.metrics.(key).distributions[]: ");
            Console.WriteLine("loadingExperience.metrics.(key).distributions[].min: ");
            Console.WriteLine("loadingExperience.metrics.(key).distributions[].max: ");
            Console.WriteLine("loadingExperience.metrics.(key).distributions[].proportion: ");
            Console.WriteLine("version: The version of PageSpeed used to generate these results.");
            Console.WriteLine("version.major: The major version number of PageSpeed used to generate these results.");
            Console.WriteLine("version.minor: The minor version number of PageSpeed used to generate these results.");
            Console.WriteLine("loadingExperience.metrics.(key).category: AVERAGE, FAST, NONE, SLOW");
            Console.WriteLine("loadingExperience.overall_category: AVERAGE, FAST, NONE, SLOW");
            Console.WriteLine("loadingExperience.initial_url: ");
            Console.WriteLine("loadingExperience.metrics.(key).percentile: ");
            Console.WriteLine("originLoadingExperience: Metrics of the aggregated page loading experience of the origin");
            Console.WriteLine("originLoadingExperience.id: The url, pattern or origin which the metrics are on.");
            Console.WriteLine("originLoadingExperience.metrics: ");
            Console.WriteLine("originLoadingExperience.metrics.(key): The type of the metric.");
            Console.WriteLine("originLoadingExperience.metrics.(key).percentile: ");
            Console.WriteLine("originLoadingExperience.metrics.(key).distributions[]: ");
            Console.WriteLine("originLoadingExperience.metrics.(key).distributions[].min: ");
            Console.WriteLine("originLoadingExperience.metrics.(key).distributions[].max: ");
            Console.WriteLine("originLoadingExperience.metrics.(key).distributions[].proportion: ");
            Console.WriteLine("originLoadingExperience.metrics.(key).category: AVERAGE, FAST, NONE, SLOW");
            Console.WriteLine("originLoadingExperience.overall_category: AVERAGE, FAST, NONE, SLOW");
            Console.WriteLine("originLoadingExperience.initial_url: ");
            Console.WriteLine("analysisUTCTimestamp: ");
            Console.WriteLine("lighthouseResult: lighthouseResult");
            Console.WriteLine("lighthouseResult.requestedUrl: The original requested url.");
            Console.WriteLine("lighthouseResult.finalUrl: The final resolved url that was audited.");
            Console.WriteLine("lighthouseResult.lighthouseVersion: The lighthouse version that was used to generate this LHR.");
            Console.WriteLine("lighthouseResult.userAgent: The user agent that was used to run this LHR.");
            Console.WriteLine("lighthouseResult.fetchTime: The time that this run was fetched.");
            Console.WriteLine("lighthouseResult.environment: Environment settings that were used when making this LHR.");
            Console.WriteLine("lighthouseResult.environment.networkUserAgent: ");
            Console.WriteLine("lighthouseResult.environment.hostUserAgent: ");
            Console.WriteLine("lighthouseResult.environment.benchmarkIndex: ");
            Console.WriteLine("lighthouseResult.runWarnings[]: List of all run warnings in the LHR. Will always output to at least `[]`.");
            Console.WriteLine("lighthouseResult.configSettings: The configuration settings for this LHR.");
            Console.WriteLine("lighthouseResult.configSettings.emulatedFormFactor: The form factor the emulation should use Acceptable values " +
                "are UNKNOWN_FORM_FACTOR, desktop, mobile, none ");
            Console.WriteLine("lighthouseResult.configSettings.locale: The locale setting");
            Console.WriteLine("lighthouseResult.configSettings.onlyCategories: ");
            Console.WriteLine("lighthouseResult.audits: Map of audits in the LHR.");
            Console.WriteLine("lighthouseResult.audits.(key): ");
            Console.WriteLine("lighthouseResult.audits.(key).id: The audit's id.");
            Console.WriteLine("lighthouseResult.audits.(key).title: The human readable title.");
            Console.WriteLine("lighthouseResult.audits.(key).description: The description of the audit.");
            Console.WriteLine("lighthouseResult.audits.(key).score: ");
            Console.WriteLine("lighthouseResult.audits.(key).scoreDisplayMode: he enumerated score display mode, Acceptable values are: +" +
                "SCORE_DISPLAY_MODE_UNSPECIFIED, binary, error, informative, manual, not_applicable, numeric");
            Console.WriteLine("lighthouseResult.audits.(key).displayValue: The value that should be displayed on the UI for this audit.");
            Console.WriteLine("lighthouseResult.audits.(key).explanation: An explanation of the errors in the audit.");
            Console.WriteLine("lighthouseResult.audits.(key).errorMessage: An error message from a thrown error inside the audit.");
            Console.WriteLine("lighthouseResult.audits.(key).warnings: ");
            Console.WriteLine("lighthouseResult.audits.(key).details: Freeform details section of the audit.");
            Console.WriteLine("lighthouseResult.audits.(key).details.(key): ");
            Console.WriteLine("lighthouseResult.categories: Map of categories in the LHR.");
            Console.WriteLine("lighthouseResult.categories.(key): ");
            Console.WriteLine("lighthouseResult.categories.(key).id: The string identifier of the category.");
            Console.WriteLine("lighthouseResult.categories.(key).title: The human-friendly name of the category");
            Console.WriteLine("lighthouseResult.categories.(key).description: A more detailed description of the category and its importance.");
            Console.WriteLine("lighthouseResult.categories.(key).score: ");
            Console.WriteLine("lighthouseResult.categories.(key).manualDescription: A description for the manual audits in the category.");
            Console.WriteLine("lighthouseResult.categories.(key).auditRefs[]: An array of references to all the audit members of this category.");
            Console.WriteLine("lighthouseResult.categories.(key).auditRefs[].id: The audit ref id.");
            Console.WriteLine("lighthouseResult.categories.(key).auditRefs[].weight: lighthouseResult.categories.(key).auditRefs[].weight");
            Console.WriteLine("lighthouseResult.categories.(key).auditRefs[].group: The category group that the audit belongs to (optional).");
            Console.WriteLine("lighthouseResult.categoryGroups: Map of category groups in the LHR.");
            Console.WriteLine("lighthouseResult.categoryGroups.(key): ");
            Console.WriteLine("lighthouseResult.categoryGroups.(key).title: ");
            Console.WriteLine("lighthouseResult.categoryGroups.(key).description: ");
            Console.WriteLine("lighthouseResult.runtimeError: Object containing the code + message of any thrown runtime errors.");
            Console.WriteLine("lighthouseResult.runtimeError.code, Acceptable values are: ERRORED_DOCUMENT_REQUEST, FAILED_DOCUMENT_REQUEST," +
                "INSECURE_DOCUMENT_REQUEST, INVALID_SPEEDLINE, NO_DCL, NO_DOCUMENT_REQUEST, NO_ERROR, NO_FCP, NO_NAVSTART, NO_SCREENSHOTS," +
                "NO_SPEEDLINE_FRAMES, NO_TRACING_STARTED, PARSING_PROBLEM, PROTOCOL_TIMEOUT, READ_FAILED, SPEEDINDEX_OF_ZERO, TRACING_ALREADY_STARTED," +
                "UNKNOWN_ERROR");
            Console.WriteLine("lighthouseResult.runtimeError.message: ");
            Console.WriteLine("lighthouseResult.timing: Timing information for this LHR.");
            Console.WriteLine("lighthouseResult.timing.total: The total duration of Lighthouse's run");
            Console.WriteLine("lighthouseResult.i18n: The internationalization strings that are required to render the LHR.");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.varianceDisclaimer: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.opportunityResourceColumnLabel: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.opportunitySavingsColumnLabel: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.errorMissingAuditInfo: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.errorLabel: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.warningHeader: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.auditGroupExpandTooltip: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.passedAuditsGroupTitle: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.notApplicableAuditsGroupTitle: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.manualAuditsGroupTitle: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.toplevelWarningsMessage: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.scorescaleLabel: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.crcLongestDurationLabel: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.crcInitialNavigation: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.lsPerformanceCategoryDescription: ");
            Console.WriteLine("lighthouseResult.i18n.rendererFormattedStrings.labDataTitle: \n\n");

        }


        private static void writeRequestInstructionsToConsole()
        {
            Console.WriteLine("This is console application for running automatic web tests from page https://developers.google.com/speed/pagespeed/insights/");
            Console.WriteLine("User specifies what query params he wants to send in url. Only url of the page he wants to test is required");
            Console.WriteLine("All other parameters are optional and define options that will be use in testing web app. Description of ");
            Console.WriteLine("parameters that can possibly be used follows: \n");
            Console.WriteLine("Category - A Lighthouse category to run; if none are given, only Performance category will be run(ACCESSIBILITY, BEST_PRACTICES, PERFORMANCE, PWA, SEO)");
            Console.WriteLine("Locale - The locale used to localize formatted results");
            Console.WriteLine("Strategy - The analysis strategy (desktop or mobile) to use, and desktop is the default");
            Console.WriteLine("Utm_campaign - Campaign name for analytics");
            Console.WriteLine("Utm_source - Campaign source for analytics");
            Console.WriteLine("captchaToken - The captcha token passed when filling out a captcha\n\n");
        }



    }
}
