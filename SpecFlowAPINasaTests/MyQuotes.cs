using System.Collections.Generic;
using SpecFlowApiSkyScannerTests.Infrastucture;

namespace SpecFlowAPINasaTests
{
    public class MyQuotes

    {
        public List<Quote> Quotes { get; set; }
        public List<Place> Places { get; set; }
        public List<Carrier> Carriers { get; set; }
        public List<MyCurrency> Currencies { get; set; }
    }

    public class Quote
    {
        public int QuoteId { get; set; }
        public List<MyOutboundLeg> OutboundLeg { get; set; }
    }

    public class MyOutboundLeg
    {
        public List<int> CarrierIds { get; set; }
        public int OriginId { get; set; }
    }

    public class Carrier
    {
        public int CarrierId { get; set; }
        public string Name { get; set; }
    }

    public class MyCurrency
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
    }
}
