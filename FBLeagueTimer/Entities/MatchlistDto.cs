using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLeagueTimer.Entities
{
    public class MatchlistDto
    {
        public List<MatchReferenceDto> Matches { set; get; }
        public int TotalGames { set; get; }
        public int StartIndex { set; get; }
        public int EndIndex { set; get; }
    }
}
