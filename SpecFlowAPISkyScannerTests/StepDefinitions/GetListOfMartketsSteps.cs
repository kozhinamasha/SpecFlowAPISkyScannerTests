using FluentAssertions;
using Newtonsoft.Json;
using SpecFlowAPINasaTests.Models;
using SpecFlowApiSkyScannerTests;
using SpecFlowApiSkyScannerTests.Infrastucture;
using TechTalk.SpecFlow;

namespace SpecFlowAPINasaTests.StepDefinitions
{
    [Binding]
    public class GetListOfMartketsSteps
    {
        private SkyScannerClient _client;
        private ApiTestContext _context;

        public GetListOfMartketsSteps(SkyScannerClient client, ApiTestContext context)
        {
            _client = client;
            _context = context;
        }

        [StepDefinition(@"I get a list of (.*) countries")]
        public void IGetAListOfCountries(int number)
        {
            var body = _context.Response.Content.ReadAsStringAsync().Result;
            _context.Countries = JsonConvert.DeserializeObject<AllCountries>(body);
            _context.Countries.Countries.Count.Should().Be(number);
        }

        [StepDefinition(@"I see country name and code")]
        public void ISeeCountryNameAndCode()
        {
            foreach (var country in _context.Countries.Countries)
            {
                country.Code.Should().NotBeNullOrEmpty();
                country.Name.Should().NotBeNullOrEmpty();
            }
        }
    }
}
