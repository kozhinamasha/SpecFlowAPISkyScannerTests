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

        public GetAirportListSteps(SkyScannerClient client)
        {
            _client = client;
        }

        [When(@"I visit the path ""(.*)""")]
        public void WhenIVisitThePath(string url)
        {
            ApiTestContext.Response = _client.VisitPath(url);
        }

        [Then(@"Status code is (.*)")]
        public void ThenStatusCodeIs(int code)
        {
            int statusCode = (int)ApiTestContext.Response.StatusCode;
            statusCode.Should().Be(code);
        }

        [StepDefinition(@"The number of the airports is (.*)")]
        public void StepDefinitionTheNumberOfTheAirports(int number)
        {
            var body = ApiTestContext.Response.Content.ReadAsStringAsync().Result;
            AllPlaces allPlaces = JsonConvert.DeserializeObject<AllPlaces>(body);
            allPlaces.Places.Count.Should().Be(number);
        }

        [StepDefinition(@"All airports for the right country (.*)")]
        public void StepDefinitionAllAirportsForTheRightCountry(string country)
        {           
            var body = ApiTestContext.Response.Content.ReadAsStringAsync().Result;
            AllPlaces allPlaces = JsonConvert.DeserializeObject<AllPlaces>(body);

            foreach (var item in allPlaces.Places)
            {
                item.CountryName.Should().Be(country);
            }
        }
    } 
}
