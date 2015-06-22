using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceClient.Core.Data;
using WebServiceClient.Core.Domain;

namespace WebServiceClient.Service.Tests
{
    public class FakeCountryRepository : IReadOnlyRepository<Country>
    {
        public IEnumerable<Country> GetAll()
        {
            return new List<Country> {
                new Country { Name = "United States", IsoCode = "US", CountryId = 840, ContinentCode = "NA", Languages = new List<string> { "en" }},
                new Country { Name = "Germany", IsoCode = "DE", CountryId = 276, ContinentCode = "EU", Languages = new List<string> { "de" }},
                new Country { Name = "Switzerland", IsoCode = "CH", CountryId = 756, ContinentCode = "EU", Languages = new List<string> { "de", "fr", "it", "rm" }},
                new Country { Name = "China", IsoCode = "CN", CountryId = 156, ContinentCode = "AS", Languages = new List<string> { "zh", "en" }},
                new Country { Name = "Chile", IsoCode = "CL", CountryId = 152, ContinentCode = "SA", Languages = new List<string> { "es" }},
            };
        }
    }
}
