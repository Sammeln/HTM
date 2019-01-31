using System.Windows.Controls;
using HomeTaskManger.ViewModel;
namespace HomeTaskManger.View
{
    /// <summary>
    /// Логика взаимодействия для TreeView.xaml
    /// </summary>
    public partial class ViewTree : UserControl
    {
        public ViewTree()
        {
            InitializeComponent();
            DataContext = new TreeViewModel();
        }
    }
}
