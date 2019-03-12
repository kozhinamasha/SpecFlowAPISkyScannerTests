using System.Collections.Generic;

namespace SpecFlowAPINasaTests.Models
{
    public class AllCountries
    {
        public List<Country> Countries { get; set; }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
