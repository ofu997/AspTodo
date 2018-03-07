using System.Collections.Generic;

namespace AspTodo.Models
{
  public class TodoViewModel
  {
    public IEnumerable<TodoItem> Items {get;set;}
  }
}