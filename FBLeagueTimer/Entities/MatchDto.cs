using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLeagueTimer.Entities
{
    public class MatchDto
    {
        public int SeasonId { set; get; }
        public int QueueId { set; get; }
        public long GameId { set; get; }
        public List<ParticipantIdentityDto> ParticipantIdentities { set; get; }
        public string GameVersion { set; get; }
        public string PlatformId { set; get; }
        public string GameMode { set; get; }
        public int MapId { set; get; }
        public string GameType { set; get; }
        public List<TeamStatsDto> Teams { set; get; }
        public List<ParticipantDto> Participants { set; get; }
        public long GameDuration { set; get; }
        public long GameCreation { set; get; }
    }
}
