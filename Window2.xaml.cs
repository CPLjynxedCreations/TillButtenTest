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
        public string price;
        //make int convert

        public Window2()
        {
            InitializeComponent();
            MainWindow mainWindow = new MainWindow();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            style = "btnItemStyle";
            name = boxItemName.Text;
            price = boxItemPrice.Text;
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            style = "btnEmptyStyle";
            name = String.Empty;
            price = String.Empty;
        }
    }
}
