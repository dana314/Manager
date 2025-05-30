using Manage.Core;
using System.Data.SQLite;
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
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Tasks (Id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT)";
            await cmd.ExecuteNonQueryAsync();
        }

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            var tasks = new List<TaskItem>();
            using var con = new SQLiteConnection(cString);
            await con.OpenAsync();
            using var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Id, Title FROM Tasks";
            using var reader = await cmd.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                tasks.Add(new TaskItem
                {
                    Id = reader.GetInt32(0),
                    Title = reader.GetString(1)
                });
            }

            return tasks;
        }

        public async Task AddTaskAsync(string title)
        {
            using var con = new SQLiteConnection(cString);
            await con.OpenAsync();
            using var cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Tasks (Title) VALUES (@title)";
            cmd.Parameters.AddWithValue("@title", title);
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

        public async Task UpdateTaskAsync(int id, string newTitle)
        {
            using var con = new SQLiteConnection(cString);
            await con.OpenAsync();
            using var cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Tasks SET Title = @title WHERE Id = @id";
            cmd.Parameters.AddWithValue("@title", newTitle);
            cmd.Parameters.AddWithValue("@id", id);
            await cmd.ExecuteNonQueryAsync();
        }
    }
}