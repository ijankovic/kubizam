using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Kubizam.Models;
using Kubizam.Repositories;
using AutoMapper;

using Microsoft.AspNet.Identity;

namespace Kubizam.ApiControllers
{
    [RoutePrefix("api")]
    public class TodoListsController : ApiController
    {
        private readonly ITodoRepository _repository;

        TodoListsController(ITodoRepository repository)
        {
            _repository = repository;
        }
        public TodoListsController() : this(new TodoRepository()) {}


        // GET: api/todolists
        public IEnumerable<TodoListViewModel> Get()
        {
            var user_id = User.Identity.GetUserId();
            var lists = _repository.GetAllTodoLists();
            var viewmodels = Mapper.Map<IEnumerable<TodoList>, IEnumerable<TodoListViewModel>>(lists);
            return viewmodels;
        }

        // GET: api/TodoLists/5
        [Authorize]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TodoLists
        [Authorize]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TodoLists/5
        [Authorize]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TodoLists/5
        [Authorize]
        public void Delete(int id)
        {
        }
    }
}
