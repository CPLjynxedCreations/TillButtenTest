using System;
using System.Diagnostics.PerformanceData;
using System.Printing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ButtenTest
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.Style = (Style)Application.Current.Resources["Style2"];
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window2 prompt = new Window2();
            prompt.Width = 1500;
            prompt.Height = 500;
            prompt.HorizontalAlignment = HorizontalAlignment.Center;
            prompt.VerticalAlignment = VerticalAlignment.Center;
            prompt.SizeToContent = SizeToContent.WidthAndHeight;
            prompt.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            prompt.button2.Click += (sender, e) => { prompt.Close(); };
            prompt.button3.Click += (sender, e) => { prompt.Close(); };
            prompt.ShowDialog();
            button1.Content = prompt.name;
            button1.Style = (Style)Application.Current.Resources[prompt.style];
        }
    }
}