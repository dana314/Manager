namespace Manage.Core
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Executor { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }

        public override string ToString()
        {
            return $"{Title} | {Executor} | {Description} | {Deadline.ToShortDateString()}";
        }
    }
}