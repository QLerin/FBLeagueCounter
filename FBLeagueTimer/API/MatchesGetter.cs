using FBLeagueTimer.Entities;
using RestSharp;
using System.Collections.Generic;

namespace FBLeagueTimer.API
{
    public class MatchesGetter
    {
        public List<Match> GetMatches(string accountId)
        {
            var client = new RestClient("https://euw1.api.riotgames.com/lol/match/v4/");

            var request = new RestRequest("matchlists/by-account/{id}", Method.GET);
            request.AddUrlSegment("id", accountId);

            request.AddHeader("X-Riot-Token", Constants.DevKey);
            var response = client.Execute<MatchesList>(request);
            return response.Data.Matches;
        }
    }
}
