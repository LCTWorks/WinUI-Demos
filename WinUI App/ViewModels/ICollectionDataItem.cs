using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI_App.ViewModels
{
    public interface ICollectionDataItem
    {
        string Title { get; set; }
        string Glyph { get; set; }
        string ActionGlyph { get; set; }
        bool IsVisible { get; set; }

        void ClearItems();
    }
}
