using System.Windows.Controls;
using ToDoList.Core;

namespace ToDoList.Wpf
{
    /// <summary>
    /// Interaction logic for WorkTask.xaml
    /// </summary>
    public partial class WorkTask : UserControl
    {
        public WorkTask()
        {
            InitializeComponent();
            // nie trzeba ustawiwać DataContext. 
        }
    }
}
