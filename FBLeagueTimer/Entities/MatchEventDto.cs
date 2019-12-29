using System.Collections.Generic;

namespace FBLeagueTimer.Entities
{
    public class MatchEventDto
    {
        public string EventType { set; get; }
        public string TowerType { set; get; }
        public int TeamId { set; get; }
        public string AscendedType { set; get; }
        public int KillerId { set; get; }
        public string LevelUpType { set; get; }
        public string PointCaptured { set; get; }
        public List<int> AssistingParticipantIds { set; get; }
        public string WardType { set; get; }
        public string MonsterType { set; get; }
        public string Type { set; get; }
        public int SkillSlot { set; get; }
        public int VictimId { set; get; }
        public long Timestamp { set; get; }
        public int AfterId { set; get; }
        public string MonsterSubType { set; get; }
        public string LaneType { set; get; }
        public int ItemId { set; get; }
        public int ParticipantId { set; get; }
        public string BuildingType { set; get; }
        public int CreatorId { set; get; }
        public MatchPositionDto Position { set; get; }
        public int BeforeId { set; get; }
    }
}