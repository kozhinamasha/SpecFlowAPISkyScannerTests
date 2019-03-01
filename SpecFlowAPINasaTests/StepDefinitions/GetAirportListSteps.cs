using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
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

        [StepDefinition(@"The QuoteId is 1")]
        public void StepDefinitionTheQuoteIdIs()
        {
            var body = ApiTestContext.Response.Content.ReadAsStringAsync().Result;
            MyQuotes myQuotes = JsonConvert.DeserializeObject<MyQuotes>(body);

            dynamic jsonData = JsonConvert.DeserializeObject<dynamic>(body);

        }

       
    }
}
