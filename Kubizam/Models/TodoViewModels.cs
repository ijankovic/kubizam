using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kubizam.Models
{
    public class TodoListViewModel
    {
        public int TodoListId { get; set; }
        public String Name { get; set; }
        public bool IsImmortal { get; set; }
    }
}