using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace WinUI_App.ViewModels
{
    
    public class HomeViewModel
    {
        ObservableCollection<ICollectionDataItem> _navItems;
        CollectionViewSource _navItemsSource;

        public ICollectionView CollectionsView
        {
            get => _navItemsSource.View;
        }

        public HomeViewModel()
        {
            _navItems = new ObservableCollection<ICollectionDataItem>();
            _navItemsSource = new CollectionViewSource { Source = _navItems };
            InitializeCollections();
        }

        private void InitializeCollections()
        {
            _navItems.Add(new FontCollectionDataItem("Local Items", ""));

            _navItems.Add(new SeparatorDataItem());
            _navItems.Add(new HeaderDataItem() { Title = "Collections", ActionGlyph = "" });
            _navItems.Add(new FontCollectionDataItem("External source", ""));
            _navItems.Add(new FontCollectionDataItem("User collection", ""));

            _navItems.Add(new SeparatorDataItem());
            _navItems.Add(new HeaderDataItem() { Title = "Folders", ActionGlyph = "" });
            _navItems.Add(new FontCollectionDataItem("Documents", ""));
            _navItems.Add(new FontCollectionDataItem("Remote", ""));
            _navItems.Add(new FontCollectionDataItem("Cloud", ""));
        }
    }
}
