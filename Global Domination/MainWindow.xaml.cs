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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Global_Domination
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Barrace\Documents\GitHub\GlobalDomination\Global Domination\_backgroundWorldMap.jpg")));
        }

        private void logIn_Click(object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void signUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void testConn_Click(object sender, RoutedEventArgs e)
        {
            string connString = "Server=GLOBALDOMINATION;" +
                                "Database=GlobalDomination;" +
                                "User Id=Barrace;" +
                                "Password=nokyal45;";

            string connDataSourceString = "Data Source=GLOBALDOMINATION;" +
                                          "User Instance=true;" +
                                          "User Id=Barrace;" +
                                          "Password=nokyal45;";
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connString; //connDataSourceString
                conn.Open();
            }
            catch
            {
                MessageBox.Show("failure :(");
            }
        }
    }
}
