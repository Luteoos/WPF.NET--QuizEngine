using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;

namespace QuizEngine
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            EventManager.RegisterClassHandler(typeof(TextBox),
                TextBox.MouseUpEvent,
                new RoutedEventHandler(TextBox_GotFocus)
            );
           
            base.OnStartup(e);
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if(sender is TextBox)
            {
                TextBox tb = sender as TextBox;
                tb.Focus();
                tb.SelectAll();
            }
        }
    }
}
