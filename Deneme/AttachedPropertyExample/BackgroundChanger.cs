using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Deneme.AttachedPropertyExample
{
    public class BackgroundChanger
    {
        public static readonly DependencyProperty IsActivePoperty = DependencyProperty.RegisterAttached(
                "IsActive",
                typeof(bool),
                typeof(BackgroundChanger),
                new PropertyMetadata(false, OnIsActiveChanged));
    
        public static bool GetIsActive(UIElement element)
        {
            return(bool)element.GetValue(IsActivePoperty);
        }

        public static void SetIsActive(UIElement element, bool value)
        {
            element.SetValue(IsActivePoperty, value);
        }

        private static void OnIsActiveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if(d is Control control )       //Control sınıfın Background özelliğine sahiptir
            {
                if((bool)e.NewValue)            //e.NewValue : IsActive property'sinin yeni değerini temsil eder.
                {
                    control.Background = new SolidColorBrush(Colors.RosyBrown);
                }
                else
                {
                    control.Background = new SolidColorBrush(Colors.BlanchedAlmond);
                }
            }
        }
    
    
    
    
    
    }
}
