using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLeagueTimer
{
    public class Summoner
    {
        public int ProfileIconId { set; get; }
        public string Name { set; get; }
        public string Puuid { set; get; }
        public long SummonerLevel { set; get; }
        public long RevisionDate { set; get; }
        public string Id { set; get; }
        public string AccountId { set; get; }
    }
}
