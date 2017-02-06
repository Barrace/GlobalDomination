using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        
        public SignUp()
        {
            InitializeComponent();
        }

        private void emailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!emailTextbox.Text.Contains("@") || 
                emailTextbox.Text.Substring(emailTextbox.Text.Length - 4, 4)[0] != '.' )//||
                //if email is taken)
            {
                errorBlock.Foreground = new SolidColorBrush(Colors.Red);
                errorBlock.Text = "Invalid Email";
            }
            else
            {
                errorBlock.Text = "";
            }
        }
        
        private void emailConfirmTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!emailConfirmTextbox.Text.Equals(emailTextbox.Text))
            {
                errorBlock.Foreground = new SolidColorBrush(Colors.Red);
                errorBlock.Text = "Emails do not match";
            }
            else
            {
                errorBlock.Text = "";
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        
        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (passwordConfirmBox.Password.Equals(passwordBox.Password) && 
                emailConfirmTextbox.Text.Equals(emailTextbox.Text) &&
                passwordBox.Password.Any(char.IsDigit) &&
                passwordBox.Password.Length >= 6 &&
                emailTextbox.Text.Contains("@") &&
                emailTextbox.Text.Substring(emailTextbox.Text.Length - 4, 4)[0] == '.')
            {
                //put data into DB
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = "Server=DESKTOP-GRD8P4F;Database=GLOBALDOMINATION;Trusted_Connection=true;";
                    conn.Open();
                    string insert = "INSERT INTO Accounts VALUES (" +
                                 (char)34 +
                                 emailTextbox.Text + 
                                 (char)34 + 
                                 ", " +
                                 (char)34 +
                                 passwordBox.Password +
                                 (char)34 +
                                 ", null, null, null, 0, 0, " +
                                 DateTime.Today + ");";
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = insert;
                }
                catch
                {
                    MessageBox.Show("DB error");
                }

                App.Current.Properties["email"] = emailTextbox.Text;
                MainWindowLoggedIn main = new MainWindowLoggedIn();
                main.Show();
                this.Close();
            }
            else
            {
                errorBlock.Text = "Error occured with signup. Please match the instructions at the top of the screen.";
            }
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!passwordBox.Password.Any(char.IsDigit))
            {
                errorBlock.Foreground = new SolidColorBrush(Colors.Red);
                errorBlock.Text = "Password must contain a number";
            }
            else if (passwordBox.Password.Length < 6)
            {
                errorBlock.Foreground = new SolidColorBrush(Colors.Red);
                errorBlock.Text = "Password must be at least 6 characters";
            }
            else
            {
                errorBlock.Text = "";
            }
        }

        private void passwordConfirmBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!passwordConfirmBox.Password.Equals(passwordBox.Password))
            {
                errorBlock.Foreground = new SolidColorBrush(Colors.Red);
                errorBlock.Text = "Passwords do not match";
            }
            else
            {
                errorBlock.Text = "";
            }
        }
    }
}
