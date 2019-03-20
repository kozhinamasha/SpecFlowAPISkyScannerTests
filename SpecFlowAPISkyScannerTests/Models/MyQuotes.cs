using System;
using System.Collections.Generic;

namespace SpecFlowApiSkyScannerTests
{
    public class MyQuotes
    {
        public List<Quote> Quotes { get; set; }
        public List<MyPlace> Places { get; set; }
        public List<Carrier> Carriers { get; set; }
        public List<MyCurrency> Currencies { get; set; }
    }

    public class Quote
    {
        public int QuoteId { get; set; }
        public double MinPrice { get; set; }
        public bool Direct { get; set; }
        public MyOutboundLeg OutboundLeg { get; set; }
        public DateTime QuoteDateTime { get; set; }
    }

    public class MyPlace
    {
        public int PlaceId { get; set; }
        public string IataCode { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string SkyscannerCode { get; set; }
        public string CityName { get; set; }
        public string CityId { get; set; }
        public string CountryName { get; set; }
    }

    public class MyOutboundLeg
    {
        public List<int> CarrierIds { get; set; }
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public DateTime DepartureDate { get; set; }
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
        public string ThousandsSeparator { get; set; }
        public string DecimalSeparator { get; set; }
        public bool SymbolOnLeft { get; set; }
        public bool SpaceBetweenAmountAndSymbol { get; set; }
        public int RoundingCoefficient { get; set; }
        public int DecimalDigits { get; set; }
    }
}
