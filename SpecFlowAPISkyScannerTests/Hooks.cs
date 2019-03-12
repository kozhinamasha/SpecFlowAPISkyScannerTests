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

        [BeforeScenario]
        public void SetUp()
        {
            ApiTestContext.ApiUrl = "https://skyscanner-skyscanner-flight-search-v1.p.rapidapi.com";
        }
    }
}
