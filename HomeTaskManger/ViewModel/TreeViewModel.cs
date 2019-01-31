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
        private ItemModel selectedItem;
        private bool isSelected;

        public ItemModel SelectedItem
        {
            get { return selectedItem; }
            set
            {
                if(selectedItem != null)
                {
                    selectedItem = value;
                }
            }
        }
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                if (isSelected != value)
                {
                    isSelected = value;
                    OnPropertyChanged("IsSelected");
                    if (isSelected)
                    {
                        SelectedItem = this.selectedItem;
                    }
                }
            }
        }
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
