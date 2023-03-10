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
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MyMovieList
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new Login();
            Application.Current.MainWindow.Show();
            this.Close();
        }
        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow = new Registration();
            Application.Current.MainWindow.Show();
            this.Close();
        }
    }
}
