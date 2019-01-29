using System.Windows.Controls;
using HomeTaskManger.ViewModel;
namespace HomeTaskManger.View
{
    /// <summary>
    /// Логика взаимодействия для TreeView.xaml
    /// </summary>
    public partial class TreeView : UserControl
    {
        public TreeView()
        {
            InitializeComponent();
            DataContext = new TreeViewModel();
        }
    }
}
