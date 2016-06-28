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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Restaurant_system.foodListItem;
namespace Restaurant_system
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                cateBtn btn = new cateBtn("test"+i.ToString());
                catePanel.Children.Add(btn);
                
            }
            for (int i = 0; i < 5; i++)
            {

                foodBtn btn = new foodBtn("test" + i.ToString());
                foodPanel.Children.Add(btn);
            }
            OrderDetailItem oderitem = new OrderDetailItem();
            orderDetailPanel.Children.Add(oderitem);
        }
    }
}
