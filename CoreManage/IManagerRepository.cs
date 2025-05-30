namespace Manage.Core
{
    public interface IManagerRepository
    {
        Task InitializeAsync();
        Task<List<TaskItem>> GetAllTasksAsync();
        Task AddTaskAsync(string title);
        Task DeleteTaskAsync(int id);
        Task UpdateTaskAsync(int id, string newTitle);
    }
}