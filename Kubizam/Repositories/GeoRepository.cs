using Kubizam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kubizam.Repositories
{
    public class GeoRepository : IGeoRepository
    {
        public IEnumerable<Country> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Country GetCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public void UpsertCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public void DeleteCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Region> GetRegionsByCountry(int countryId)
        {
            throw new NotImplementedException();
        }

        public Region GetRegion(int regionId)
        {
            throw new NotImplementedException();
        }

        public void UpsertRegion(Region region)
        {
            throw new NotImplementedException();
        }

        public void DeleteRegion(int regionId)
        {
            throw new NotImplementedException();
        }
    }
}