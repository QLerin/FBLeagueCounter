using System.Collections.Generic;

namespace FBLeagueTimer.Entities
{
    public class ParticipantTimelineDto
    {
        public string Lane { set; get; }
        public int ParticipantId { set; get; }
        public Dictionary<string, double> CsDiffPerMinDeltas { set; get; }
        public Dictionary<string, double> GoldPerMinDeltas { set; get; }
        public Dictionary<string, double> XpDiffPerMinDeltas { set; get; }
        public Dictionary<string, double> CreepsPerMinDeltas { set; get; }
        public Dictionary<string, double> XpPerMinDeltas { set; get; }
        public string Role { set; get; }
        public Dictionary<string, double> DamageTakenDiffPerMinDeltas { set; get; }
        public Dictionary<string, double> DamageTakenPerMinDeltas { set; get; }
    }
}
