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
    /// Interaction logic for PassNPlay.xaml
    /// </summary>
    public partial class PassNPlay : Window
    {
        public PassNPlay()
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

        private void compSlider_MouseDown(object sender, MouseButtonEventArgs e)
        {
            compSlider.Maximum = 5 - personSlider.Value;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            PlayWindow play = new PlayWindow();
            play.Show();
            this.Close();
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            GameWindowPassNPlay game = new GameWindowPassNPlay((int)personSlider.Value, (int)compSlider.Value);
            game.Show();
            this.Close();
        }
    }
}
