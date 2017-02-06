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
    /// Interaction logic for PlayWindow.xaml
    /// </summary>
    public partial class PlayWindow : Window
    {
        public PlayWindow()
        {
            InitializeComponent();
            emailBlock.Text = (String)App.Current.Properties["email"];
            emailBlock.Foreground = new SolidColorBrush(Colors.DarkCyan);
        }

        private void resumeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowLoggedIn main = new MainWindowLoggedIn();
            main.Show();
            this.Close();
        }

        private void playLocalButton_Click(object sender, RoutedEventArgs e)
        {
            PassNPlay win = new PassNPlay();
            win.Show();
            this.Close();
        }

        private void emailBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AccountSettings accountWindow = new AccountSettings();
            accountWindow.Show();
            this.Close();
        }

        private void playWithFriend_Click(object sender, RoutedEventArgs e)
        {
            PlayWithFriend friendWin = new PlayWithFriend();
            friendWin.Show();
            this.Close();
        }

        private void playOnlineButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
