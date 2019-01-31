using HomeTaskManger.Model;
using HomeTaskManger.Data;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace HomeTaskManger.ViewModel
{
    public class TreeViewModel : BaseViewModel, INotifyPropertyChanged
    {

        ObservableCollection<ItemModel> subItems;

        public ObservableCollection<ItemModel> SubItems
        {
            get
            {
                //if (tree != null)
                //{
                //    return tree;
                //}
                //return tree = new ObservableCollection<ItemModel>();
                return subItems;
            }
            set
            {
                subItems = value;
                OnPropertyChanged(nameof(SubItems));
            }
        }

        public TreeViewModel()
        {
            SubItems = InMemoryData.Instance.Items;
        }

    }
}
