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

namespace ToolBox
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwin = new MainWindow();
            mainwin.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ADHelper ad = new ADHelper();
            ToolboxMain toolwin = new ToolboxMain();

            if (ad.AuthenticateUser(txtDomain.Text,
           txtUserName.Text, txtPassword.Password))
            {
                toolwin.Show();
                this.Close();
            }
            else
                MessageBox.Show("Unable to Authenticate Using the Supplied Credentials");
        }
    }
}
