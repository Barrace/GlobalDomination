﻿using System;
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
    /// Interaction logic for GameWindowPassNPlay.xaml
    /// </summary>
    public partial class GameWindowPassNPlay : Window
    {
        int numHumanPlayers;
        int numCompPlayers;
        public GameWindowPassNPlay(int numHuman, int numComp)
        {
            numHumanPlayers = numHuman;
            numCompPlayers = numComp;
            InitializeComponent();
        }
    }
}
