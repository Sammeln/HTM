using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace HomeTaskManger.Model
{
    public class ItemModel : INotifyPropertyChanged
    {
        #region Fields

        private string name;
        private int id;
        private ObservableCollection<ItemModel> subItems;

        #endregion

        #region Props
        
        public string Name
        {
            get => name;
            set
            {
                name = "Item #" + Id.ToString();
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public ObservableCollection<ItemModel> SubItems
        {
            get
            {
                if(subItems != null)
                {
                    return subItems;
                }
                subItems = new ObservableCollection<ItemModel>();
                return subItems;
            }

            set
            {
                subItems = value;
                OnPropertyChanged(nameof(SubItems));
            }
        }

        #endregion

        #region CTOR

        public ItemModel(SubItemLvl subItem)
        {
            SubCTOR(subItem);
        }
        public ItemModel()
        {

        }

        #endregion

        private void SubCTOR(SubItemLvl itemLvl)
        {
            if(itemLvl == 0)
            {
                return;
            }
            for (int i = 0; i < (int)itemLvl; i++)
            {
                SubItems.Add(new ItemModel { Id = i + 1 });
            }
        }
        #region NotifyPropChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        } 
        #endregion
    }
    
}
