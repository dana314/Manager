using System.Data.SQLite;
using Manage.Core;
namespace Manage.Data
{
    public class ManagerRepository : IManagerRepository
    {
        private string cString = "Data Source=Tasks.db;Version=3;";

        public async Task InitializeAsync()
        {
            using var connect = new SQLiteConnection(cString);
            await connect.OpenAsync();
            using var cmd = connect.CreateCommand();
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Executors (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT)";
            await cmd.ExecuteNonQueryAsync();
            cmd.CommandText = @"CREATE TABLE IF NOT EXISTS Tasks (
                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    Title TEXT NOT NULL,
                                    Description TEXT,
                                    Executor INTEGER NOT NULL,
                                    Deadline DATETIME,
                                    FOREIGN KEY(Executor) REFERENCES Executors(Id)
                                )";
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            var tasks = new List<TaskItem>();
            using var con = new SQLiteConnection(cString);
            await con.OpenAsync();
            using var cmd = con.CreateCommand();
            cmd.CommandText = @"
                SELECT t.Id, t.Title, t.Description, t.Executor, t.Deadline, e.Name 
                FROM Tasks t
                JOIN Executors e ON t.Executor = e.Id";

            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                tasks.Add(new TaskItem
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1),
                    Description = reader.IsDBNull(2) ? null : reader.GetString(2),
                    Executor = reader.GetInt32(3),
                    Deadline = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4),
                    Name = reader.GetString(5)
                });
            }

            return tasks;
        }

        public async Task<List<Executor>> GetAllExecutorsAsync()
        {
            var executors = new List<Executor>();
            using var con = new SQLiteConnection(cString);
            await con.OpenAsync();
            using var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Id, Name FROM Executors";
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                executors.Add(new Executor
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1)
                });
            }

            return executors;
        }

        public async Task<int> AddExecutorAsync(string name)
        {
            using var con = new SQLiteConnection(cString);
            await con.OpenAsync();
            using var cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO Executors (Name) VALUES (@name); SELECT last_insert_rowid()";
            cmd.Parameters.AddWithValue("@name", name);

            var result = await cmd.ExecuteScalarAsync();
            return Convert.ToInt32(result);
        }

        public async Task AddTaskAsync(string title, string description, int executorId, string executorName, DateTime deadline)
        {
            using var con = new SQLiteConnection(cString);
            await con.OpenAsync();
            using var cmd = con.CreateCommand();

            cmd.CommandText = @"INSERT INTO Tasks (Title, Description, Executor, Deadline) 
                                 VALUES (@title, @description, @executor, @deadline)";

            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@executor", executorId);
            cmd.Parameters.AddWithValue("@deadline", deadline.ToString("yyyy-MM-dd HH:mm:ss"));

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task UpdateTaskAsync(TaskItem selectedTask, string title, string description, int executor, string name, DateTime deadline)
        {
            using var con = new SQLiteConnection(cString);
            await con.OpenAsync();
            using var cmd = con.CreateCommand();

            cmd.CommandText = @"UPDATE Tasks SET Title = @title,Description = @description,Executor = @executor,
            Deadline = @deadline WHERE Id = @id";

            cmd.Parameters.AddWithValue("@id", selectedTask.Id); 
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@executor", executor);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@deadline", deadline.ToString("yyyy-MM-dd HH:mm:ss"));

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            using var con = new SQLiteConnection(cString);
            await con.OpenAsync();
            using var cmd = con.CreateCommand();

            cmd.CommandText = "DELETE FROM Tasks WHERE Id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            await cmd.ExecuteNonQueryAsync();
        }
    }
}