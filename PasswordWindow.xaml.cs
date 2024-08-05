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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class PasswordWindow : Window
    {
        public string userInput;

        public PasswordWindow()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (userInput != String.Empty)
            {
                userInput = passBox.Text;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            userInput = String.Empty;
        }
    }
}
