using System.Net.Http;

namespace SpecFlowApiSkyScannerTests
{
    public static class ApiTestContext
    {
        public static  string ApiUrl { get; set; }
        public static HttpResponseMessage Response { get; set; }
    }
}
