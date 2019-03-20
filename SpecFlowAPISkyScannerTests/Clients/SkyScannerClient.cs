using System;
using System.Net.Http;

namespace SpecFlowApiSkyScannerTests.Infrastucture
{
    public class SkyScannerClient : BaseClient
    {
        private ApiTestContext _context;
        public SkyScannerClient(ApiTestContext context) : base(new HttpClient
        {
            BaseAddress = new Uri("https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com")
        })
        {
            _context = context;
        }

        public HttpResponseMessage VisitPath(string url)
        {
            return Get(url);
        }
    }
}