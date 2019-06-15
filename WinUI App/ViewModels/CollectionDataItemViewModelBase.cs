using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI_App.ViewModels
{
    public abstract class CollectionDataItemViewModelBase : ViewModelBase, ICollectionDataItem
    {
        private string _title;
        private bool _visible = true;
        private string _glyph;
        private string _aglyph;

        public string Title
        {
            get => _title;
            set
            {
                Set(ref _title, value);
                RaisePropertyChanged();
            }
        }
        public bool IsVisible
        {
            get => _visible;
            set => Set(ref _visible, value);
        }

        public string Glyph
        {
            get => _glyph;
            set
            {
                Set(ref _glyph, value);
                RaisePropertyChanged();
            }
        }

        public string ActionGlyph
        {
            get => _aglyph;
            set
            {
                Set(ref _aglyph, value);
                RaisePropertyChanged();
            }
        }

        public CollectionDataItemViewModelBase()
        {
        }
        public CollectionDataItemViewModelBase(string title, string glyph)
        {
            Title = title;
            Glyph = glyph;
        }

        public virtual void ClearItems()
        {

        }
    }
}
