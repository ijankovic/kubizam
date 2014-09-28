using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kubizam.Models
{
    public class TodoList
    {
        public int TodoListId { get; set; }
        public IdentityUser User { get; set; }
        public String Name { get; set; }
        public bool IsImmortal { get; set; }
        public virtual ICollection<TodoItem> TodoItems { get; set; }
    }

    public class TodoItem
    {
        public int TodoItemId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public TodoList TodoList { get; set; }
        public DateTime DueDateTime { get; set; }
        public DateTime? RemindDateTime { get; set; }
        public Country LocationCountry { get; set; }
        public Region LocationRegion { get; set; }

        /*
         * [tc] #todo stuff to add:
         * - item order
         * - file attachments
         * - related items
         */
    }
}