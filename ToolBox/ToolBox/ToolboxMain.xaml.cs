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

namespace ToolBox
{
    /// <summary>
    /// Interaction logic for ToolboxMain.xaml
    /// </summary>
    public partial class ToolboxMain : Window
    {
        public ToolboxMain()
        {
            InitializeComponent();
        }

        private void ScoreBoard_Click(object sender, RoutedEventArgs e)
        {
            ScoreboardWinMain scorewin = new ScoreboardWinMain();
            scorewin.Show();
        }
    }
}
