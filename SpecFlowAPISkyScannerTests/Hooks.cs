using SpecFlowApiSkyScannerTests;
using TechTalk.SpecFlow;

namespace SpecFlowAPINasaTests
{
    [Binding]
    public class Hooks
    {
        public Hooks()
        {
        }

        private ApiTestContext _context;

        [BeforeScenario]
        public void SetUp()
        {
            _context = new ApiTestContext();
            _context.ApiUrl = "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com";
        }
    }
}
