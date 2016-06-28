using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Restaurant_system.Common;
namespace Restaurant_system.AdminItem
{
    class normalItem: Button
    {
        public normalItem(string title)
        {
            this.Content = title;
            this.Name = title;
            this.Background = AppconfigSet.blueColor;
            this.Foreground = AppconfigSet.whiteColor;
            this.FontSize = 30;
            this.Height = 100;
            this.Margin = new System.Windows.Thickness(10,10,10,0);
        }
    }
}
