using FBLeagueTimer.Entities;
using RestSharp;

namespace FBLeagueTimer.API
{
    public class MatchGetter
    {
        public MatchDto GetMatch(string matchId)
        {
            var client = new RestClient("https://euw1.api.riotgames.com/lol/match/v4/");

            var request = new RestRequest("matches/{id}", Method.GET);
            request.AddUrlSegment("id", matchId);

            request.AddHeader("X-Riot-Token", Constants.DevKey);
            var response = client.Execute<MatchDto>(request);
            return response.Data;
        }
    }
}
