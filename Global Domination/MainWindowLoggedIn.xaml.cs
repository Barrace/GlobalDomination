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
    /// Interaction logic for MainWindowLoggedIn.xaml
    /// </summary>
    /// 
    /*
     *  setting: App.Current.Properties["NameOfProperty"] = 5;
        getting: string myProperty = App.Current.Properties["NameOfProperty"];
     * 
     */
    public partial class MainWindowLoggedIn : Window
    {
        public MainWindowLoggedIn()
        {
            InitializeComponent();
            emailBlock.Text = (String)App.Current.Properties["email"];
            emailBlock.Foreground = new SolidColorBrush(Colors.DarkCyan);
        }

        private void emailBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AccountSettings accountWindow = new AccountSettings();
            accountWindow.Show();
            this.Close();
        }
    }
}
