using FBLeagueTimer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLeagueTimer.API
{
    public class PlayerMatches
    {
        public List<MatchReferenceDto> GetPlayersAllMatches(string name)
        {
            var summoner = new SummonerGetter().GetSummonerName(name);
            var matchCollection = new List<MatchReferenceDto>();

            var matchHistory = new MatchHistoryGetter();
            var weirdMatchList = matchHistory.GetMatches(summoner.AccountId, 999999);
            if (weirdMatchList == null)
            {
                return matchCollection;
            }
            weirdMatchList.EndIndex = 0;
            var matchAmount = weirdMatchList.TotalGames;

            var previousMatchList = weirdMatchList;
            while (matchCollection.Count < matchAmount)
            {
                var tempMatchList = matchHistory.GetMatches(summoner.AccountId, previousMatchList.EndIndex);
                if (tempMatchList == null)
                {
                    return matchCollection;
                }
                matchCollection.AddRange(tempMatchList.Matches);
                previousMatchList = tempMatchList;
            }
            return matchCollection;
        }
    }
}
