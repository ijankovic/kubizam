using Kubizam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Kubizam.ApiControllers
{
    [RoutePrefix("api")]
    public class TodoListsController : ApiController
    {
        // GET: api/TodoLists
        public IEnumerable<TodoListViewModel> Get()
        {
            var results = new List<TodoListViewModel>()
            {
                new TodoListViewModel {Id = 1, Name = "First task list"},
                new TodoListViewModel {Id = 2, Name = "Second task list"},
                new TodoListViewModel {Id = 3, Name = "Third task list"}
            };
            return results;
        }

        // GET: api/TodoLists/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TodoLists
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TodoLists/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TodoLists/5
        public void Delete(int id)
        {
        }
    }
}
