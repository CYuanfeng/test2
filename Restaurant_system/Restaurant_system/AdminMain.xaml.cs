using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Restaurant_system.AdminItem;
namespace Restaurant_system
{
    /// <summary>
    /// AdminMain.xaml 的交互逻辑
    /// </summary>
    public partial class AdminMain : MetroWindow
    {
        public AdminMain()
        {
            InitializeComponent();
            topItemButton item1 = new topItemButton("添加快餐");
            topPanel.Children.Add(item1);
            item1.Click += fastFoodClick;
            meatTitle.Visibility = Visibility.Hidden;
            vegeTitle.Visibility = Visibility.Hidden;

            

           

        }
        public void fastFoodClick(object obj,EventArgs e)
        {
            meatTitle.Visibility = Visibility.Visible;
            vegeTitle.Visibility = Visibility.Visible;
            topItemButton item2 = new topItemButton("饭");
            staplePanel.Children.Add(item2);


            normalItem nor1 = new normalItem("菜心");
            vagePanel.Children.Add(nor1);
        }
    }
}
