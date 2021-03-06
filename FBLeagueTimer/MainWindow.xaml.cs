﻿using FBLeagueTimer.API;
using FBLeagueTimer.Database;
using FBLeagueTimer.Features;
using System.Windows;

//TODO move out to viewmodel/binding and stuff
namespace FBLeagueTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = PlayerName.Text;
            if (string.IsNullOrEmpty(name))
            {
                return;
            }
            var count = new FirstBloodsCounter().GetFirstBloodCount(name);
            FirstBloodCount.Content = count.Counts.ToString();
            LoggingTextBox.Text = count.Logging;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var name = PlayerName.Text;
            if (string.IsNullOrEmpty(name))
            {
                return;
            }
            var playerMatches = new PlayerMatches();
            var matchesCollection = playerMatches.GetPlayersAllMatches(name);
            new PlayerMatchesDatabase().GetDatabase(matchesCollection, name);
        }
    }
}
