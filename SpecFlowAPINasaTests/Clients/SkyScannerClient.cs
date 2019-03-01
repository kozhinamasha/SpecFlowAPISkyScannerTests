using System;
using System.Net.Http;

namespace SpecFlowApiSkyScannerTests.Infrastucture
{
    public class SkyScannerClient:BaseClient
    {
        public SkyScannerClient() : base(new HttpClient
        {
            BaseAddress = new Uri(ApiTestContext.ApiUrl)
        })
        {
        }

        public HttpResponseMessage VisitPath(string url)
        {
            return Get(url);
        }
    }
}
