using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Deneme.DataBinding
{
    /// <summary>
    /// DataBindingOrnek.xaml etkileşim mantığı
    /// </summary>
    public partial class DataBindingOrnek : Window
    {
        public string MyText { get; set; } = "İlk deneme";
        private double sliderValue;
        public double SliderValue
        {
            get
            {
                return sliderValue;
            }
            set
            {
                sliderValue = value;
                OnPropertyChanged(nameof(SliderValue));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public DataBindingOrnek()
        {
            InitializeComponent();
            DataContext = this;        //Binding için veri kaynağını tanımlıyoruz
        }
    }
}
