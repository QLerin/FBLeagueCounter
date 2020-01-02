using FBLeagueTimer.Entities;
using FBLeagueTimer.Utilities.LimitingRequests;
using RestSharp;

namespace FBLeagueTimer.API
{
    public class MatchTimelineGetter
    {
        public MatchTimelineDto GetMatchTimeline(string matchId)
        {
            ShittyLimiter.DelayUntilAvailable();
            var client = new RestClient("https://euw1.api.riotgames.com/lol/match/v4/");

            var request = new RestRequest("timelines/by-match/{id}", Method.GET);
            request.AddUrlSegment("id", matchId);

            request.AddHeader("X-Riot-Token", Constants.DevKey);
            var response = client.Execute<MatchTimelineDto>(request);
            ShittyLimiter.AddRequest();
            return response.Data;
        }
    }
}
