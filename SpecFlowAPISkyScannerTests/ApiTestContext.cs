using System.Net.Http;
using SpecFlowAPINasaTests.Models;

namespace SpecFlowApiSkyScannerTests
{
    public class ApiTestContext
    {
        public string ApiUrl { get; set; }
        public HttpResponseMessage Response { get; set; }
        public AllCountries Countries { get; set; }
    }
}
