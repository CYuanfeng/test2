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
            for (int i = 0; i < 5;i++ )
            {
                topItemButton item = new topItemButton("test"+i.ToString());
                topPanel.Children.Add(item);
            }

        }
    }
}
