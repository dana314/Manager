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
            Logger.Info("Пользователь нажал на кнопку ДОБАВИТЬ");
            
            string task = textTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                await _managerRepository.AddTaskAsync(task);
                textTask.Clear();
                await LoadTasksAsync();
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
                if (!string.IsNullOrEmpty(newTitle))
                {
                    await _managerRepository.UpdateTaskAsync(selectedTask.Id, newTitle);
                    textTask.Clear();
                    await LoadTasksAsync();
                }
            }
        }
    }
}