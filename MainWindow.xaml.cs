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

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            btnItem1.Style = (Style)Application.Current.Resources["Style2"];
        }

        private void btnItem1_Click(object sender, RoutedEventArgs e)
        {
            if (canEdit)
            {
                canEdit = false;
                Window2 prompt = new Window2();
                prompt.Owner = Application.Current.MainWindow;
                prompt.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                prompt.SizeToContent = SizeToContent.WidthAndHeight;
                //prompt.Width = 1500;
                //prompt.Height = 500;
                prompt.btnOk.Click += (sender, e) => { prompt.Close(); };
                prompt.btnCancel.Click += (sender, e) => { prompt.Close(); };
                prompt.ShowDialog();
                if (prompt.name != String.Empty)
                {
                    btnItem1.Content = prompt.name;
                    btnItem1.Style = (Style)Application.Current.Resources[prompt.style];
                }
                else
                {
                    btnItem1.Content = String.Empty;
                    btnItem1.Style = (Style)Application.Current.Resources["Style2"];
                }
            }
            else
            {
                //add item to sale
            }

            //DONE FOR TOGGLE BUTTON WITH WFP PAFE CODE FOR BOOL
            /*if (boolIsEdit)
            {
                Window2 prompt = new Window2();
                prompt.Owner = Application.Current.MainWindow;
                prompt.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                prompt.SizeToContent = SizeToContent.WidthAndHeight;
                //prompt.Width = 1500;
                //prompt.Height = 500;
                prompt.button2.Click += (sender, e) => { prompt.Close(); };
                prompt.button3.Click += (sender, e) => { prompt.Close(); };
                prompt.ShowDialog();
                if (prompt.name != String.Empty)
                {
                    btnItem1.Content = prompt.name;
                    btnItem1.Style = (Style)Application.Current.Resources[prompt.style];
                }
                else
                {
                    btnItem1.Content = String.Empty;
                    btnItem1.Style = (Style)Application.Current.Resources["Style2"];
                }
            }
            else
            {
                //add item to sale
            }*/
        }

        private void btnManage_Click(object sender, RoutedEventArgs e)
        {
            Window4 prompt = new Window4();
            prompt.Owner = Application.Current.MainWindow;
            prompt.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            prompt.SizeToContent = SizeToContent.WidthAndHeight;
            prompt.btnOk.Click += (sender, e) => { prompt.Close(); };
            prompt.btnCancel.Click += (sender, e) => { prompt.Close(); };
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