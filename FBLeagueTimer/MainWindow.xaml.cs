using FBLeagueTimer.API;
using System.Linq;
using System.Windows;

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

        //TODO move out to viewmodel
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var summoner = new SummonerGetter().GetSummonerName("QLerin");
            var matches = new MatchesGetter().GetMatches(summoner.AccountId);
            var matchTimeLineGetter = new MatchTimelineGetter();

            //var matchTimeline = new List<MatchTimelineDto>();
            //foreach (var match in matches)
            //{
            //    matchTimeline.Add(matchTimeLineGetter.GetMatchTimeline(match.GameId.ToString()));
            //}

            var a = matchTimeLineGetter.GetMatchTimeline(matches.First().GameId.ToString());
        }
    }
}
