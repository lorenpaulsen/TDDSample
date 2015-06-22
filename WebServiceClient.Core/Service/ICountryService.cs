using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceClient.Core.Domain;

namespace WebServiceClient.Core.Service
{
    public interface ICountryService
    {
        IEnumerable<Country> GetAll();

        IEnumerable<IGrouping<string, Country>> GetCountriesByContinent();

        Country FindByIsoCode(string code);

        IEnumerable<Country> GetCountriesByLanguage(string languageCode);
    }
}
