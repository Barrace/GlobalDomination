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
    /// Interaction logic for AccountSettings.xaml
    /// </summary>
    public partial class AccountSettings : Window
    {
        public AccountSettings()
        {
            InitializeComponent();
        }

        private void signOutButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Properties["email"] = null;
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
