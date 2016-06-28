using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Restaurant_system.Common;
using System.Windows;
namespace Restaurant_system.foodListItem
{
    class cateBtn : Button
    {
        public cateBtn(string title)
        {
            this.Content = title;
            this.Name = title;
            this.Background = AppconfigSet.blueColor;
            this.Foreground = AppconfigSet.whiteColor;
            this.FontSize = 30;
            this.Width = 90;
            this.Margin = new System.Windows.Thickness(10,10,0,10);
            this.Style = FindResource("itemButton") as Style;
        }
    }
}
