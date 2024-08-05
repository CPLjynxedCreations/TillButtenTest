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
        public bool boolIsEdit { get; set; }
        public bool canEdit;
        public string passWord = "1234";
        public string itm1price;
        public string itm2price;
        public string name;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnItem1_Click(object sender, RoutedEventArgs e)
        {
            //DONE FOR TOGGLE BUTTON WITH WFP PAFE CODE FOR ++BOOL++
            /*if (boolIsEdit)
            {

            }*/
            if (canEdit)
            {
                canEdit = false;
                Window2 prompt = new Window2();
                prompt.Owner = Application.Current.MainWindow;
                prompt.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                prompt.SizeToContent = SizeToContent.WidthAndHeight;
                prompt.btnOk.Click += (sender, e) => { prompt.Close(); };
                prompt.btnCancel.Click += (sender, e) => { prompt.Close(); };
                prompt.boxItemName.Focus();
                prompt.ShowDialog();
                if (prompt.name != String.Empty)
                {
                    btnItem1.Content = prompt.name;
                    itm1price = prompt.price;
                    btnItem1.Style = (Style)Application.Current.Resources[prompt.style];
                }
                else
                {
                    btnItem1.Content = String.Empty;
                    btnItem1.Style = (Style)Application.Current.Resources["btnEmptyStyle"];
                }
            }
            else
            {
                if (btnItem1.Content != String.Empty)
                {
                    lblName.Text = Convert.ToString(btnItem1.Content);
                    lblPrice.Text = itm1price;
                }
            }
        }
        private void btnItem2_Click(object sender, RoutedEventArgs e)
        {
            if (canEdit)
            {
                canEdit = false;
                Window2 prompt = new Window2();
                prompt.Owner = Application.Current.MainWindow;
                prompt.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                prompt.SizeToContent = SizeToContent.WidthAndHeight;
                prompt.btnOk.Click += (sender, e) => { prompt.Close(); };
                prompt.btnCancel.Click += (sender, e) => { prompt.Close(); };
                prompt.boxItemName.Focus();
                prompt.ShowDialog();
                if (prompt.name != String.Empty)
                {
                    btnItem2.Content = prompt.name;
                    itm2price = prompt.price;
                    btnItem2.Style = (Style)Application.Current.Resources[prompt.style];
                }
                else
                {
                    btnItem2.Content = String.Empty;
                    btnItem2.Style = (Style)Application.Current.Resources["btnEmptyStyle"];
                }
            }
            else
            {
                if (btnItem2.Content != String.Empty)
                {
                    lblName.Text = Convert.ToString(btnItem2.Content);
                    lblPrice.Text = itm2price;
                }
            }
        }
        private void btnManage_Click(object sender, RoutedEventArgs e)
        {
            Window4 prompt = new Window4();
            prompt.Owner = Application.Current.MainWindow;
            prompt.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            prompt.SizeToContent = SizeToContent.WidthAndHeight;
            prompt.btnOk.Click += (sender, e) => { prompt.Close(); };
            prompt.btnCancel.Click += (sender, e) => { prompt.Close(); };
            prompt.passBox.Focus();
            prompt.ShowDialog();
            if (prompt.userInput == passWord)
            {
                Edit();
            }
        }
        private void Edit()
        {
            Window3 prompt = new Window3();
            prompt.Owner = Application.Current.MainWindow;
            prompt.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            prompt.SizeToContent = SizeToContent.WidthAndHeight;
            prompt.btnEdit.Click += (sender, e) => { prompt.Close(); };
            prompt.ShowDialog();
            if (prompt.canEditbtn)
            {
                canEdit = true;
            }
        }
    }
}