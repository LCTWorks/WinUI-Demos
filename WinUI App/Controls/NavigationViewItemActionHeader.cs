using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace WinUI_App.Controls
{
    public class NavigationViewItemActionHeader: NavigationViewItemHeader
    {
        public Windows.UI.Xaml.Controls.IconElement ActionIcon
        {
            get { return (Windows.UI.Xaml.Controls.IconElement)GetValue(ActionIconProperty); }
            set { SetValue(ActionIconProperty, value); }
        }
        public static readonly DependencyProperty ActionIconProperty =
            DependencyProperty.Register("ActionIcon", typeof(Windows.UI.Xaml.Controls.IconElement), typeof(NavigationViewItemActionHeader), new PropertyMetadata(null));
    }
}
