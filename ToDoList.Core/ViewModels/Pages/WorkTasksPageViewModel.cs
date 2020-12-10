using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace ToDoList.Core
{
    public class WorkTasksPageViewModel : BaseViewModel
    {
        public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();
        public string NewWorkTaskTitle { get; set; }
        public string NewWorkTaskDescription { get; set; }
        public ICommand AddNewTaskCommand { get; set; }
        public ICommand DeleteSelectedWorkTasksCommand { get; set; }
        public WorkTasksPageViewModel()
        {
            AddNewTaskCommand = new RelayCommand(AddNewTask);
            DeleteSelectedWorkTasksCommand = new RelayCommand(DeleteSelectedWorkTasks);
        }
        private void AddNewTask()
        {
            var newTask = new WorkTaskViewModel()
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreatedDate = DateTime.Now
            };
            WorkTaskList.Add(newTask);

            NewWorkTaskTitle = string.Empty;
            NewWorkTaskDescription = string.Empty;

            //OnPropertyChanged(nameof(NewWorkTaskTitle));
            //OnPropertyChanged(nameof(NewWorkTaskDescription));
        }
        private void DeleteSelectedWorkTasks()
        {
            var selectedTasks = WorkTaskList.Where(t => t.IsSelected).ToList();

            foreach (var task in selectedTasks)
            {
                WorkTaskList.Remove(task);
            }    
        }

    }
}
