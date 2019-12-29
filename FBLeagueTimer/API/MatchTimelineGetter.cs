using FBLeagueTimer.Entities;
using RestSharp;

namespace FBLeagueTimer.API
{
    public class MatchTimelineGetter
    {
        public MatchTimelineDto GetMatchTimeline(string matchId)
        {
            var client = new RestClient("https://euw1.api.riotgames.com/lol/match/v4/");

            var request = new RestRequest("timelines/by-match/{id}", Method.GET);
            request.AddUrlSegment("id", matchId);

            request.AddHeader("X-Riot-Token", Constants.DevKey);
            var response = client.Execute<MatchTimelineDto>(request);
            return response.Data;
        }
    }
}
