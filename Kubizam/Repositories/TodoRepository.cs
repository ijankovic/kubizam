using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kubizam.Models;


namespace Kubizam.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly ApplicationDbContext _context;
        private string _user_id;

        public TodoRepository()
        {
            _context = new ApplicationDbContext();
            /* [tc] #todo _user_id needs to be injected once we've set up DI properly*/
            _user_id = HttpContext.Current.User.Identity.GetUserId();
        }

        public IEnumerable<TodoList> GetAllTodoLists()
        {
            return _context.TodoLists.Where(x => x.User.Id == _user_id).ToList();
        }

        public TodoList GetTodoList(int todoListId)
        {
            throw new NotImplementedException();
        }

        public void UpsertTodoList(TodoList todoList)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodoList(int todoListId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetTodoItems(int todoListId)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetTodoItem(int todoItemId)
        {
            throw new NotImplementedException();
        }

        public void UpsertTodoItem(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteTodoItem(int todoItemId)
        {
            throw new NotImplementedException();
        }

    }
}