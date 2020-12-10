using System.Windows.Controls;
using ToDoList.Core;

namespace ToDoList.Wpf
{
    /// <summary>
    /// Interaction logic for WorkTasksPage.xaml
    /// </summary>
    public partial class WorkTasksPage : Page
    {
        public WorkTasksPage()
        {
            InitializeComponent();
            DataContext = new WorkTasksPageViewModel();
        }
    }
}
