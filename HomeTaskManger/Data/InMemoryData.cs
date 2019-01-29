using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using HomeTaskManger.Model;

namespace HomeTaskManger.Data
{
    public class InMemoryData : INotifyPropertyChanged
    {
        #region Fields

        private static InMemoryData instance;
        private static object SyncRoot = new object();
        private ObservableCollection<ItemModel> items; 
        #endregion

        #region Props
        public static InMemoryData Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (SyncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new InMemoryData();
                        }
                    }
                }
                return instance;
            }
        }
        public ObservableCollection<ItemModel> Items
        {
            get => items;
            set
            {
                items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        #endregion

        #region Methods
        public static InMemoryData GetInstance()
        {
            if (instance == null)
            {
                lock (SyncRoot)
                {
                    if (instance == null)
                    {
                        instance = new InMemoryData();
                    }
                }
            }
            return instance;
        }
        #endregion

        #region CTOR
        public InMemoryData()
        {
            Items = new ObservableCollection<ItemModel>
            {
                new ItemModel(SubItemLvl.Three),
                new ItemModel(SubItemLvl.None),
                new ItemModel(SubItemLvl.One),
                new ItemModel
                {
                    SubItems = new ObservableCollection<ItemModel>
                    {
                        new ItemModel(SubItemLvl.Three),
                        new ItemModel(SubItemLvl.None),
                        new ItemModel(SubItemLvl.One),
                        new ItemModel(SubItemLvl.Two)
                    }
                }

            };
        }
        #endregion

        #region NotifyPropChanged

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

    }
}
