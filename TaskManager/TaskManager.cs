using Manage.Core;
using NLog;
namespace Manage.UI
{
    public partial class Manager : Form
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly IManagerRepository _managerRepository;


        public Manager(IManagerRepository managerRepository)
        {
            Logger.Info("Инициализация конструктора");
            InitializeComponent();
            _managerRepository = managerRepository;
            Load += OnLoadAsync;
        }

        private async void OnLoadAsync(object sender, EventArgs e)
        {
            await _managerRepository.InitializeAsync();
            await LoadTasksAsync();
        }

        private async Task LoadTasksAsync()
        {
            listTasks.Items.Clear();
            var tasks = await _managerRepository.GetAllTasksAsync();
            foreach (var task in tasks)
            {
                listTasks.Items.Add(task);
            }
        }

        private async void AddBTN_Click(object sender, EventArgs e)
        {
            string input = textTask.Text.Trim();
            if (string.IsNullOrEmpty(input))
                return;

            string[] parts = input.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length >= 4)
            {
                string title = parts[0].Trim();
                string name = parts[1].Trim();
                string description = parts[2].Trim();
                string deadlineStr = parts[3].Trim();

                DateTime deadline;
                if (!DateTime.TryParse(deadlineStr, out deadline))
                {
                    MessageBox.Show("Неверный формат дедлайна");
                    return;
                }

                var executors = await _managerRepository.GetAllExecutorsAsync();
                var selectedExecutor = executors.Find(e => e.Name == name);

                if (selectedExecutor == null)
                {

                    return;
                }

                int executor = selectedExecutor.Id;

                await _managerRepository.AddTaskAsync(title, description, executor, name, deadline);
                await LoadTasksAsync();
                textTask.Clear();
            }
            else
            {
                MessageBox.Show("Введите задачу в формате: Название | Исполнитель | Описание | Дедлайн");
            }
        }

        private async void DeleteBTN_Click(object sender, EventArgs e)
        {
            Logger.Info("Пользователь нажал на кнопку УДАЛИТЬ");
            if (listTasks.SelectedItem is TaskItem selectedTask)
            {
                await _managerRepository.DeleteTaskAsync(selectedTask.Id);
                await LoadTasksAsync();
            }
        }

        private async void EditBTN_Click(object sender, EventArgs e)
        {
            Logger.Info("Пользователь нажал на кнопку ИЗМЕНИТЬ");

            if (listTasks.SelectedItem is TaskItem selectedTask)
            {
                string newTitle = textTask.Text.Trim();
                string newDescription = selectedTask.Description;
                string newName = selectedTask.Name;
                DateTime newDeadline = selectedTask.Deadline;

                await _managerRepository.UpdateTaskAsync(selectedTask, newTitle, newDescription, selectedTask.Executor, newName, newDeadline);
                textTask.Clear();
                await LoadTasksAsync();
            }
        }

        
    }
}