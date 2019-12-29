namespace FBLeagueTimer.Entities
{
    public class Match
    {
        public string Lane { set; get; }
        public long GameId { set; get; }
        public int Champion { set; get; }
        public string PlatformId { set; get; }
        public int Season { set; get; }
        public int Queue { set; get; }
        public string Role { set; get; }
        public long Timestamp { set; get; }
    }
}
