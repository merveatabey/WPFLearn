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

namespace Deneme
{
    /// <summary>
    /// DockPanel.xaml etkileşim mantığı
    /// </summary>
    public partial class DockPanel : Window
    {
        public DockPanel()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WrapPanel wp = new WrapPanel();
            wp.Background = new SolidColorBrush(Colors.Yellow);
            wp.Orientation = Orientation.Horizontal;
            wp.Width = 350;
            wp.Height = 200;
            wp.HorizontalAlignment = HorizontalAlignment.Left;
            wp.VerticalAlignment = VerticalAlignment.Bottom;
            
            Button btn1 = new Button();
            btn1.Width = 50;
            btn1.Height = 50;
            btn1.Content = "btn1";

            Button btn2 = new Button();
            btn2.Width = 200;
            btn2.Height = 50;
            btn2.Content = "btn2";

            wp.Children.Add(btn1);
            wp.Children.Add(btn2);
            
            this.Content = wp;
            //grid.Children.Add(wp);
        }
    }
}
