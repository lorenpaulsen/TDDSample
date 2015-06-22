using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceClient.Core.Data;
using WebServiceClient.Core.Domain;

namespace WebServiceClient.Core.Data
{
    public class GeoNamesCountryRepository : IReadOnlyRepository<Country>
    {
        private const string _countryInfoUrl = "http://api.geonames.org/countryInfoJSON?formatted=true&&username=lpaulsen&style=full";

        public IEnumerable<Country> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
