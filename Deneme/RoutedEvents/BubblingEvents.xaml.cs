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

namespace Deneme.RoutedEvents
{
    /// <summary>
    /// BubblingEvents.xaml etkileşim mantığı
    /// </summary>
    public partial class BubblingEvents : Window
    {
        public BubblingEvents()
        {
            InitializeComponent();

        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("StackPanel MouseDown Event Tetiklendi");
          
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
            MessageBox.Show("Button MouseDown Event Tetiklendi");
            
        }

        private void RadioButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            MessageBox.Show(rb.Content.ToString());
        }
    }
}
