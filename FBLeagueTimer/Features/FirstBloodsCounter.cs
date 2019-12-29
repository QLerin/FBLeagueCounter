using FBLeagueTimer.API;
using FBLeagueTimer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FBLeagueTimer.Features
{
    public class FirstBloodsCounter
    {
        public int GetFirstBloodCount(string name)
        {
            var summoner = new SummonerGetter().GetSummonerName(name);
            var matches = new MatchHistoryGetter().GetMatches(summoner.AccountId);

            var matchGetter = new MatchGetter();
            var matchDtos = new List<MatchDto>();
            foreach (var match in matches)
            {
                var matchDto = matchGetter.GetMatch(match.GameId.ToString());
                if (matchDto != null)
                {
                    matchDtos.Add(matchDto);
                }
            }

            int firstBloods = 0;
            foreach (var matchDto in matchDtos)
            {
                var participantIdentity = matchDto.ParticipantIdentities.FirstOrDefault(part => part.Player.SummonerId == summoner.Id);
                if (participantIdentity == null)
                {
                    continue;
                }
                var participantId = participantIdentity.ParticipantId;

                var participant = matchDto.Participants.FirstOrDefault(part => part.ParticipantId == participantId);
                if (participant == null)
                {
                    continue;
                }

                if (participant.Stats.FirstBloodKill)
                {
                    firstBloods++;
                }
            }

            return firstBloods;
        }
    }
}
