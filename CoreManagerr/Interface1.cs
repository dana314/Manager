using System.Collections.Generic;
using System.Threading.Tasks;
namespace Manager
{
    public interface IManagerRepository
    {
        Task<List<TaskItem>> GetAllTasks();
        Task AddTask(string title);
        Task DeleteTask(int id);
        Task UpdateTask(int id, string newTitle);
    }
}
