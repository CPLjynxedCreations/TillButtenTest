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

namespace ButtenTest
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public string style;
        public string name;

        public Window2()
        {
            InitializeComponent();
            MainWindow mainWindow = new MainWindow();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            style = "Style1";
            name = boxName.Text;
            //name = "Product";
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            style = "Style2";
            name = String.Empty;
            //name = "No Product";
        }
    }
}
