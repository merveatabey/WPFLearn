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
    /// Grid.xaml etkileşim mantığı
    /// </summary>
    public partial class Grid : Window
    {
        public Grid()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            int value = 30;
            for(int i = 0; i<4; i++)
            {
                grid.ColumnDefinitions.Add( new ColumnDefinition
                {
                    Width = new GridLength(value, GridUnitType.Star)
                });
               
                value += 30;
                grid.ShowGridLines = true;
                this.Content = grid;
            }

           


          
            

            
        }
    }
}
