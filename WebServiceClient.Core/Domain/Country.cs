using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceClient.Core.Domain
{
    /// <summary>
    /// Represents an ISO 3166 country
    /// </summary>
    public class Country
    {
        /// <summary>
        /// The country's ISO numeric code
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// The country's short name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The country's 2 character ISO country code
        /// </summary>
        public string IsoCode { get; set; }

        /// <summary>
        /// The two character continent code for this country
        /// </summary>
        public string ContinentCode { get; set; }

        public ICollection<string> Languages { get; set; }
    }
}
