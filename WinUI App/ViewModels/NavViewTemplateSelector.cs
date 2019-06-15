using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace WinUI_App.ViewModels
{
    public class NavViewTemplateSelector : DataTemplateSelector
    {
        public DataTemplate NavItemTemplate { get; set; }
        public DataTemplate NavSeparatorTemplate { get; set; }
        public DataTemplate NavHeaderTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (!(item is ICollectionDataItem data))
            {
                return null;
            }
            if (data is HeaderDataItem)
            {
                return NavHeaderTemplate;
            }
            if (data is SeparatorDataItem)
            {
                return NavSeparatorTemplate;
            }
            return NavItemTemplate;
        }
    }
}
