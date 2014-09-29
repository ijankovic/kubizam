using Kubizam.Models;
using Kubizam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kubizam
{
    [RoutePrefix("api")]
    public class GeoController : ApiController
    {
        private readonly IGeoRepository _repository;

        GeoController(IGeoRepository repository)
        {
            _repository = repository;
        }
        public GeoController() : this (new GeoRepository()){}


        [Route("countries")]
        [HttpGet]
        public IEnumerable<Country> GetAllCountries()
        {
            return _repository.GetAllCountries();
        }

        [Route("countries/{id}/regions")]
        [HttpGet]
        public IEnumerable<Region> GetRegionsByCountry(int id)
        {
            return _repository.GetRegionsByCountry(id);
        }


        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}