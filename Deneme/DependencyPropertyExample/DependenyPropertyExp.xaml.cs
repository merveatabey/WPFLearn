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

namespace Deneme.DependencyPropertyExample
{
    /// <summary>
    /// DependenyPropertyExp.xaml etkileşim mantığı
    /// </summary>
    public partial class DependenyPropertyExp : Window
    {
        private readonly Random random = new Random();
        public DependenyPropertyExp()
        {
            InitializeComponent();
        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            //Rastgele RGB değerleri oluştur
            byte r = (byte)random.Next(0, 256);
            byte g = (byte)random.Next(0, 256);
            byte b = (byte)random.Next(0, 256);

            //Color sınıfını kullanarak rastgele bir renk oluşturuyoruz
            Color randomColor = Color.FromRgb(r, g, b);

            //Kullanıcı kontrolüne erşip arka plan rengini değiştiriyoruz
            var control = (ColorChangingControl)this.FindName("MyControl");
            control.BackgroundColor = new SolidColorBrush(randomColor);
        }
    }
}
