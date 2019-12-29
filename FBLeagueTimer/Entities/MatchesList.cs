using System.Collections.Generic;

namespace FBLeagueTimer.Entities
{
    public class MatchesList
    {
        public List<Match> Matches { set; get; }
        public int TotalGames { set; get; }
        public int StartIndex { set; get; }
        public int EndIndex { set; get; }
    }
}
