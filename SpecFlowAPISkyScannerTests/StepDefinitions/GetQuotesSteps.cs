using FluentAssertions;
using Newtonsoft.Json;
using SpecFlowApiSkyScannerTests;
using SpecFlowApiSkyScannerTests.Infrastucture;
using TechTalk.SpecFlow;

namespace SpecFlowAPINasaTests.StepDefinitions
{
    [Binding]
    public class GetQuotesSteps
    {
        private SkyScannerClient _client;
        private ApiTestContext _context;

        public GetQuotesSteps(SkyScannerClient client, ApiTestContext context)
        {
            _client = client;
            _context = context;
        }

        [StepDefinition(@"The data (.*) about quotes is correct")]
        public void StepDefinitionTheDataIsCorrect(double data)
        {
            var body = _context.Response.Content.ReadAsStringAsync().Result;
            MyQuotes myQuotes = JsonConvert.DeserializeObject<MyQuotes>(body);
            foreach (var quote in myQuotes.Quotes)
            {
                quote.OutboundLeg.OriginId.Should().Be(81727);
                quote.OutboundLeg.DestinationId.Should().Be(60987);
                quote.MinPrice.Should().Be(data);
            }
        }
    }
}
