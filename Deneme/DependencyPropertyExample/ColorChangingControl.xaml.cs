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

namespace Deneme.DependencyPropertyExample
{
    /// <summary>
    /// ColorChangingControl.xaml etkileşim mantığı
    /// </summary>
    public partial class ColorChangingControl : UserControl
    {
        public ColorChangingControl()
        {
            InitializeComponent();
        }

        //Dependecy Property tanımlama
        public static readonly DependencyProperty BackgroundColorProperty = DependencyProperty.Register(
            "BackgroundColor",                      //özellik adı
            typeof(Brush),                          //özellik türü   
            typeof(ColorChangingControl),           //sahip olunan sınıf
            new PropertyMetadata(Brushes.LightGray)    //varsayılan değer
     );
            
        //CLR Wrapper
        public Brush BackgroundColor
        {
            get => (Brush)GetValue(BackgroundColorProperty);
            set => SetValue(BackgroundColorProperty, value);
        }
    
    };
}
