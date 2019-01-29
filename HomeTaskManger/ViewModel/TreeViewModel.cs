using HomeTaskManger.Model;
using HomeTaskManger.Data;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace HomeTaskManger.ViewModel
{
    public class TreeViewModel : BaseViewModel, INotifyPropertyChanged
    {
        ObservableCollection<ItemModel> tree;

        public ObservableCollection<ItemModel> Tree
        {
            get
            {
                if (tree != null)
                {
                    return tree;
                }
                return tree = new ObservableCollection<ItemModel>();
            }
            set
            {
                tree = value;
                OnPropertyChanged(nameof(Tree));
            }
        }

        public TreeViewModel()
        {
            tree = InMemoryData.Instance.Items;
        }

    }
}
