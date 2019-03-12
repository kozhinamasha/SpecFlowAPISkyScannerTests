using Newtonsoft.Json;
using SpecFlowApiSkyScannerTests;
using SpecFlowApiSkyScannerTests.Infrastucture;
using SpecFlowAPINasaTests.Models;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace SpecFlowAPINasaTests.StepDefinitions
{
    [Binding]
    public class GetListOfMartketsSteps
    {
        private SkyScannerClient _client;

        public GetListOfMartketsSteps(SkyScannerClient client)
        {
            _client = client;
        }

        [StepDefinition(@"I get a list of (.*) countries")]
        public void IGetAListOfCountries(int number)
        {
            var body = ApiTestContext.Response.Content.ReadAsStringAsync().Result;
            AllCountries countries = JsonConvert.DeserializeObject<AllCountries>(body);
            countries.Countries.Count.Should().Be(number);
            foreach (var country in countries.Countries)
            {
                country.Code.Should().NotBeNullOrEmpty();
                country.Name.Should().NotBeNullOrEmpty();
            }
        }
    }
}
