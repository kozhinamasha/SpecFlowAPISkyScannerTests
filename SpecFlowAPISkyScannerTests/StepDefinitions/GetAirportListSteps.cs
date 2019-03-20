using FluentAssertions;
using Newtonsoft.Json;
using SpecFlowApiSkyScannerTests;
using SpecFlowApiSkyScannerTests.Infrastucture;
using TechTalk.SpecFlow;

namespace SpecFlowAPINasaTests.StepDefinitions
{
    [Binding]
    public class GetAirportListSteps
    {
        private SkyScannerClient _client;
        private ApiTestContext _context;

        public GetAirportListSteps(SkyScannerClient client, ApiTestContext context)
        {
            _client = client;
            _context = context;
        }

        [When(@"I visit the path ""(.*)""")]
        public void WhenIVisitThePath(string url)
        {
            _context.Response = _client.VisitPath(url);
        }

        [Then(@"Status code is (.*)")]
        public void ThenStatusCodeIs(int code)
        {
            int statusCode = (int)_context.Response.StatusCode;
            statusCode.Should().Be(code);
        }

        [StepDefinition(@"The number of the airports is (.*)")]
        public void StepDefinitionTheNumberOfTheAirports(int number)
        {
            var body = _context.Response.Content.ReadAsStringAsync().Result;
            AllPlaces allPlaces = JsonConvert.DeserializeObject<AllPlaces>(body);
            allPlaces.Places.Count.Should().Be(number);
        }

        [StepDefinition(@"All airports for the right country (.*)")]
        public void StepDefinitionAllAirportsForTheRightCountry(string country)
        {
            var body = _context.Response.Content.ReadAsStringAsync().Result;
            AllPlaces allPlaces = JsonConvert.DeserializeObject<AllPlaces>(body);

            foreach (var item in allPlaces.Places)
                item.CountryName.Should().Be(country);

        }
    }
}