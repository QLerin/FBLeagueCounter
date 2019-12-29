using FBLeagueTimer.API;
using FBLeagueTimer.Entities;
using FBLeagueTimer.Utilities;
using System.Collections.Generic;
using System.Linq;

namespace FBLeagueTimer.Features
{
    public class FirstBloodsCounter
    {
        public FirstBloodsInformation GetFirstBloodCount(string name)
        {
            var firstBloodInformation = new FirstBloodsInformation();

            var summoner = new SummonerGetter().GetSummonerName(name);
            var matches = new MatchHistoryGetter().GetMatches(summoner.AccountId);

            if (matches == null)
            {
                return firstBloodInformation;
            }

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
            matchDtos.Reverse();

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
                    firstBloodInformation.Counts++;
                    var gameTime = DateTimeToUnixTimeStamp.GetTimeFromUnixTime(matchDto.GameCreation);
                    firstBloodInformation.Logging += $"{firstBloodInformation.Counts}. {gameTime.ToShortDateString()} {gameTime.ToShortTimeString()}  {matchDto.GameMode} \n";
                }
            }

            return firstBloodInformation;
        }
    }
}
