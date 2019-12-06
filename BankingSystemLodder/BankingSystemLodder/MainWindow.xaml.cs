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

namespace BankingSystemLodder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameBox.Text;
            string password = PasswordBox1.Password;

            if (username.Length == 0)
            {
                MessageBox.Show("Enter Username!");
            }
            else if (PasswordBox1.Password.Length == 0)
            {
                MessageBox.Show("Enter Password!");
                PasswordBox1.Focus();
            }
            else if (username == "User1" &&  password == "UserPass1")
            {
                MessageBox.Show("Welcome User1!");
            }
            else
            {
                MessageBox.Show("Not valid! Try again!");
            }

        }
    }
}
