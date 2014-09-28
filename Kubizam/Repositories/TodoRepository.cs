using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kubizam.Models;

namespace Kubizam.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        public IEnumerable<TodoList> GetAllTodoLists()
        {
            throw new NotImplementedException();
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