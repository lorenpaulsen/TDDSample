using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceClient.Core.Data;
using WebServiceClient.Core.Domain;
using WebServiceClient.Core.Service;

namespace WebServiceClient.Service
{
    public class CountryService : ICountryService
    {
        private readonly IReadOnlyRepository<Country> _repository;

        public CountryService(IReadOnlyRepository<Country> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Country> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IGrouping<string, Country>> GetCountriesByContinent()
        {
            throw new NotImplementedException();
        }

        public Country FindByIsoCode(string code)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Country> GetCountriesByLanguage(string languageCode)
        {
            throw new NotImplementedException();
        }

        public Country FindByCountryId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
