using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMauiClient.Models;

namespace TodoMauiClient.DataServices
{
    public interface IRestDataService
    {
        Task<List<ToDo>> GetAllToDosAsync();
        Task AddTodoAsync(ToDo toDo);
        Task DeleteToDoAsync(int id);
        Task UpdateToDoAsync(ToDo toDo);

    }
}
