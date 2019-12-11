using System;
using System.Globalization;
using System.Linq;

using Syncfusion.TreeView.Engine;

using Xamarin.Forms;

namespace GettingStartedBound.Converter
{
    public class TreeViewNodeArrowVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && parameter != null)
            {
                var treeViewNode = (parameter as BindableObject)?.BindingContext as TreeViewNode;

                if (treeViewNode == null) return false;

                var items = treeViewNode.ChildNodes.Select(n => n.Content).ToList();

                if (items.Contains(value) && items.IndexOf(value) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
