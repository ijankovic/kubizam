using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kubizam.Models;

namespace Kubizam.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<TodoList> GetAllTodoLists();
        TodoList GetTodoList(int todoListId);
        void UpsertTodoList(TodoList todoList);
        void DeleteTodoList(int todoListId);

        IEnumerable<TodoItem> GetTodoItems(int todoListId);
        TodoItem GetTodoItem(int todoItemId);
        void UpsertTodoItem(TodoItem todoItem);
        void DeleteTodoItem(int todoItemId);
    }
}