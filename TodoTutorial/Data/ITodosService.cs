using System.Collections.Generic;
using TodoTutorial.Models;

namespace TodoTutorial.Data
{
    public interface ITodosService
    {
        IList<Todo> GetTodos();
        void AddTodo(Todo todo);
        public void RemoveTodo(int todoId);
    }
}