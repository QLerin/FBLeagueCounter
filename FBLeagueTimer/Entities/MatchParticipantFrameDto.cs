namespace FBLeagueTimer.Entities
{
    public class MatchParticipantFrameDto
    {
        public int TotalGold { set; get; }
        public int TeamScore { set; get; }
        public int ParticipantId { set; get; }
        public int Level { set; get; }
        public int CurrentGold { set; get; }
        public int MinionsKilled { set; get; }
        public int DominionScore { set; get; }
        public MatchPositionDto Position { set; get; }
        public int Xp { set; get; }
        public int JungleMinionsKilled { set; get; }

    }
}
