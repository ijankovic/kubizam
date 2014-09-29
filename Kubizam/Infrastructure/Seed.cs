using Kubizam.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Kubizam.Infrastructure
{
    public class Migrations
    {
        public class Database
        {
            public static void SeedDatabase(ApplicationDbContext context)
            {
                var countries = new List<Country>()
                {
                    new Country() { CountryId = 1, Name = "Croatia" },
                    new Country() { CountryId = 2, Name = "United Kingdom" },
                    new Country() { CountryId = 3, Name = "United States" }
                };
                countries.ForEach(c => context.Countries.AddOrUpdate(c));

                var regions = new List<Region>()
                {
                    new Region() { RegionId = 1, Country = countries[0], Name = "Kvarner" },
                    new Region() { RegionId = 2, Country = countries[0], Name = "Dalmacija" },
                    new Region() { RegionId = 3, Country = countries[1], Name = "Great Britain" },
                    new Region() { RegionId = 4, Country = countries[1], Name = "Scotland" },
                    new Region() { RegionId = 5, Country = countries[2], Name = "West Coast" },
                    new Region() { RegionId = 6, Country = countries[2], Name = "East Coast" }
                };
                regions.ForEach(r => context.Regions.AddOrUpdate(r));
                
                context.SaveChanges();
            }
        }

    }
}