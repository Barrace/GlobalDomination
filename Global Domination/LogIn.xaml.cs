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

namespace Global_Domination
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void logIn_Click(object sender, RoutedEventArgs e)
        {
            //if combination isnt in db, 
            errorTextblock.Text = "Invalid combination. Please try again.";
            //else..
            App.Current.Properties["email"] = emailTextBox.Text;
            MainWindowLoggedIn main = new MainWindowLoggedIn();
            main.Show();
            this.Close();
        }
        
    }
}
