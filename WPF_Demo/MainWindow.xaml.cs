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
using Gma.UserActivityMonitor;

namespace WPF_Demo
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        private GlobalEventProvider _provider;

        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void InHook(object sender, RoutedEventArgs e)
        {
            _provider.MouseClickExt += _provider_MouseClickExt;
        }

        private void UnHook(object sender, RoutedEventArgs e)
        {
            _provider.MouseClickExt -= _provider_MouseClickExt;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _provider = new GlobalEventProvider();
        }
        private void _provider_MouseClickExt(object sender, MouseEventExtArgs e)
        {
            if (e.Device.Equals("Touch"))
            {
                Console.WriteLine("Touch");
            }
            else
            {
                Console.WriteLine("Mouse");
            }
        }
    }
}
