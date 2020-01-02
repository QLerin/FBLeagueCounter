using FBLeagueTimer.Utilities.LimitingRequests;
using RestSharp;

namespace FBLeagueTimer.API
{
    public class SummonerGetter
    {
        public Summoner GetSummonerName(string name)
        {
            ShittyLimiter.DelayUntilAvailable();
            var client = new RestClient("https://euw1.api.riotgames.com/lol/summoner/v4/");

            var request = new RestRequest("summoners/by-name/{id}", Method.GET);
            request.AddUrlSegment("id", name);

            request.AddHeader("X-Riot-Token", Constants.DevKey);
            var response = client.Execute<Summoner>(request);
            ShittyLimiter.AddRequest();
            return response.Data;
        }
    }
}
