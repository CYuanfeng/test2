using Restaurant_system.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Restaurant_system.foodListItem
{
    class foodBtn : Button
    {
        public foodBtn(string title)
        {
            this.Content = title;
            this.Name = title;
            this.Background = AppconfigSet.blueColor;
            this.Foreground = AppconfigSet.whiteColor;
            this.FontSize = 34;
            this.Height = 80;
            this.Margin = new System.Windows.Thickness(0,10,0,0);
        }
    }
}
