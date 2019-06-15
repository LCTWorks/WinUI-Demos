using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI_App.ViewModels
{
    public class HeaderDataItem : CollectionDataItemViewModelBase
    {
        public HeaderDataItem()
            :this(string.Empty, string.Empty)
        {
        }
        public HeaderDataItem(string title, string glyph):base(title, glyph)
        {
        }
    }
}
