using System.Collections.Generic;

namespace FBLeagueTimer.Entities
{
    public class ParticipantDto
    {
        public ParticipantStatsDto Stats { set; get; }
        public int ParticipantId { set; get; }
        public List<RuneDto> Runes { set; get; }
        public ParticipantTimelineDto Timeline { set; get; }
        public int TeamId { set; get; }
        public int Spell2Id { set; get; }
        public List<MasteryDto> Masteries { set; get; }
        public string highestAchievedSeasonTier { set; get; }
        public int Spell1Id { set; get; }
        public int ChampionId { set; get; }
    }
}
