namespace Manage.Core
{
    public interface IManagerRepository
    {
        Task InitializeAsync();
        Task<List<TaskItem>> GetAllTasksAsync();
        Task AddTaskAsync(string title, string description,int executor, string name, DateTime deadline);
        Task DeleteTaskAsync(int id);
        Task UpdateTaskAsync(TaskItem selectedTask, string title, string description, int executor, string name, DateTime deadline);
        Task<List<Executor>> GetAllExecutorsAsync();
        Task<int> AddExecutorAsync(string name);
    }
}