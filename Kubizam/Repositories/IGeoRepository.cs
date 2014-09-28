using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kubizam.Models;

namespace Kubizam.Repositories
{
    public interface IGeoRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountry(int countryId);
        void UpsertCountry(Country country);
        void DeleteCountry(int countryId);
        //void SaveCountry(Country country); /* And upon this charge, cry, 'God for Harry, England and St. George!' */

        IEnumerable<Region> GetRegionsByCountry(int countryId);
        Region GetRegion(int regionId);
        void UpsertRegion(Region region);
        void DeleteRegion(int regionId);
    }
}