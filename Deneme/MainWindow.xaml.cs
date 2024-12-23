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

namespace Deneme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Butona Tıklandı");
            bool b = (bool)cb1.IsChecked;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Button btn2 = new Button();
            //btn2.Width = 60;
            //btn2.Height = 30;
            //btn2.Margin = new Thickness(40, 50, 0, 0);
            //btn2.Content = "Güncelle";
            //grid.Children.Add(btn2);

            //BitmapImage resim = new BitmapImage(new Uri("~/Images/images.jpeg"));
            //img.Source = resim;

            //CornerRadius kose  = new CornerRadius(20,20,20,20);
            //border.CornerRadius = kose;

            string[]dizi = {"a", "b","c"};
            foreach(var item in dizi)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Content = item;
                cb2.Items.Add(checkBox);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(cb1.IsChecked == true)
            {
                MessageBox.Show("tıklandı");
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            MessageBox.Show(rb.Content.ToString());
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           ComboBoxItem c = cb.SelectedItem as ComboBoxItem;
            MessageBox.Show(c.Content.ToString());
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Image ımage = (Image)list.SelectedItem;
            secilenImg.Source = ımage.Source;
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            list.SelectedIndex = new Random().Next(2);
            Image img = (Image)list.SelectedItem;
            secilenImg.Source = img.Source;
        }

        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            string value = e.NewValue.ToString();
            MessageBox.Show(value);
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            string tarih = date.SelectedDate.ToString();
        }
    }
}
