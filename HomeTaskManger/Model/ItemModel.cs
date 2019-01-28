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
            get => subItems;
            set
            {
                subItems = value;
                OnPropertyChanged(nameof(SubItems));
            }
        }

        #endregion

        private void SubCTOR(SubItemLvl itemLvl)
        {

        }
        #region NotifyPropChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        } 
        #endregion
    }
    public enum SubItemLvl
    {
        None = 0,
        One,
        Two,
        Three
    }
}
