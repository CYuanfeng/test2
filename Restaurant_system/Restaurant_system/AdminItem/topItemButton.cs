using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Restaurant_system.Common;
using System.Windows;
using YuanCommon;
namespace Restaurant_system.AdminItem
{
    class topItemButton:Button
    {
        public topItemButton(string title)
        {
            this.Content = title;
            this.Name = title;
            this.Background = AppconfigSet.blueColor;
            this.Foreground = AppconfigSet.whiteColor;
            this.FontSize = 36;
            this.Width = 200;
            this.Margin = new System.Windows.Thickness(10, 10, 0, 10);
            this.Style = FindResource("itemButton") as Style;
            

        }
    }
}
