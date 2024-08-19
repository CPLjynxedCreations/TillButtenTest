using ButtenTest.Windows;
using System;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Printing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    public partial class TillWindow : Window
    {
        public bool boolIsEdit { get; set; }
        public bool canEdit;
        public string passWord = "1234";
        public string itm1price;
        public string itm2price;
        public string name;

        public string newPrice = "40";

        //added for stackpanel
        private int total = 0;

        public TillWindow()
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
                EnterProductWindow prompt = new EnterProductWindow();
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
                EnterProductWindow prompt = new EnterProductWindow();
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
            PasswordWindow prompt = new PasswordWindow();
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
            ManageWindow prompt = new ManageWindow();
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

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            //added new button to stackpanel
            int count = stackThem2.Children.Count;
            var btnName = "btn" + count;
            var txtAmount = "txtAmount" + count;
            var txtPrice = "txtPrice" + count;

            TextBlock block1 = new TextBlock();
            block1.Text = "Amount";
            block1.Name = txtAmount;
            block1.TextAlignment = TextAlignment.Center;
            block1.IsHitTestVisible = false;
            block1.Height = 20;
            block1.Padding = new Thickness(0, 2, 0, 0);

            ToggleButton btn = new ToggleButton();
            btn.Content = Convert.ToString(btnButton.Content);
            btn.Name = btnName;
            Debug.WriteLine(btn.Name);
            btn.Checked += btnRemove_Checked;
            btn.BorderThickness = new Thickness(0);
            btn.Height = 20;

            TextBlock block2 = new TextBlock();
            block2.Text = newPrice;
            block2.Name = txtPrice;
            block2.TextAlignment = TextAlignment.Center;
            block2.IsHitTestVisible = false;
            block2.Height = 20;
            block2.Padding = new Thickness(0, 2, 0, 0);


            stackThem1.Children.Add(block1);
            stackThem2.Children.Add(btn);
            stackThem3.Children.Add(block2);

            /*
            //set location of new window
            PopWindow popWindow = new PopWindow();
            popWindow.WindowStyle = WindowStyle.None;
            popWindow.WindowStartupLocation = WindowStartupLocation.Manual;
            popWindow.Left = 900;
            popWindow.Top = 600;
            popWindow.Show();
            */
        }
        private void btnRemove_Checked(object sender, RoutedEventArgs e)
        {
            int count = stackThem2.Children.Count;
            ToggleButton toggleBut = (ToggleButton)sender;
            string name = toggleBut.Name;
            for (int i = 0; i <= count; i++)
            {
                //string name = "btn" + i;
                foreach (UIElement item in stackThem2.Children)
                {
                    if (item.GetType() == typeof(ToggleButton))
                    {
                        ToggleButton tglBut = (ToggleButton)item;
                        if (tglBut.Name == name)
                        {
                            Debug.WriteLine(tglBut.Name);
                            stackThem2.Children.RemoveAt(i);
                            stackThem1.Children.RemoveAt(i);
                            stackThem3.Children.RemoveAt(i);
                            tglBut.IsChecked = false;
                            return;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //checks for text in textBlock then adds all together
            int count = stackThem2.Children.Count;
            string strAmount;
            int amount;


            for (int i = 0; i <= count; i++)
            {
                string name = "txtPrice" + i;
                foreach (UIElement item in stackThem3.Children)
                {
                    if (item.GetType() == typeof(TextBlock))
                    {
                        TextBlock txtBlock = (TextBlock)item;
                        if (txtBlock.Name == name)
                        {
                            strAmount = txtBlock.Text;
                            amount = Convert.ToInt32(strAmount);
                            total = total + amount;
                        }
                    }
                }
            }
            Debug.WriteLine(total);
        }
    }
}