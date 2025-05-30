namespace Manage
{
    public partial class Manager : Form
    {
        private readonly IManagerRepository imanagerRepository;

        public Manager(IManagerRepository managerRepository)
        {
            InitializeComponent();
            imanagerRepository = managerRepository;
            Load += OnLoad;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            await imanagerRepository.Initialize();
            await LoadTasks();
        }

        private async Task LoadTasks()
        {
            listTasks.Items.Clear();
            var tasks = await imanagerRepository.GetAllTasks();
            foreach (var task in tasks)
            {
                listTasks.Items.Add(task);
            }
        }

        private async void AddBTN_Click(object sender, EventArgs e)
        {
            string task = textTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                await imanagerRepository.AddTask(task);
                textTask.Clear();
                await LoadTasks();
            }
        }

        private async void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem is TaskItem selectedTask)
            {
                await imanagerRepository.DeleteTaskAsync(selectedTask.Id);
                await LoadTasks();
            }
        }

        private async void EditBTN_Click(object sender, EventArgs e)
        {
            if (listTasks.SelectedItem is TaskItem selectedTask)
            {
                string newTitle = textTask.Text.Trim();
                if (!string.IsNullOrEmpty(newTitle))
                {
                    await imanagerRepository.UpdateTask(selectedTask.Id, newTitle);
                    textTask.Clear();
                    await LoadTasks();
                }
            }
        }
    }

}