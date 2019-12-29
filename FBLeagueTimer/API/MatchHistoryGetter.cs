using FBLeagueTimer.Entities;
using FBLeagueTimer.Utilities;
using RestSharp;
using System;
using System.Collections.Generic;

namespace FBLeagueTimer.API
{
    public class MatchHistoryGetter
    {
        public List<Match> GetMatches(string accountId)
        {
            var client = new RestClient("https://euw1.api.riotgames.com/lol/match/v4/");

            var request = new RestRequest("matchlists/by-account/{id}", Method.GET);
            request.AddUrlSegment("id", accountId);

            request.AddHeader("X-Riot-Token", Constants.DevKey);
            request.AddQueryParameter("endIndex", "90");
            request.AddQueryParameter("beginTime", new DateTime(2019, 12, 13).UnixTimeStamp());
            var response = client.Execute<MatchesList>(request);
            return response.Data.Matches;
        }
    }
}
