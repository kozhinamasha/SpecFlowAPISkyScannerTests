using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using NUnit.Framework;

namespace SpecFlowApiSkyScannerTests
{
    public class AllPlaces
    {
        public List<Place> Places { get; set; }
    }

    public class Place
    { 
        public string PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
