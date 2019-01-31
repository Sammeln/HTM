using System.Collections.ObjectModel;
using System.Windows;
using HomeTaskManger.Model;
using HomeTaskManger.ViewModel;

namespace HomeTaskManger
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new TreeViewModel();

        }

    }
}
