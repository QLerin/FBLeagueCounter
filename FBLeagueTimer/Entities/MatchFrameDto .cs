using System.Collections.Generic;

namespace FBLeagueTimer.Entities
{
    public class MatchFrameDto
    {
        public long Timestamp { set; get; }
        public Dictionary<string, MatchParticipantFrameDto> ParticipantFrames { set; get; }
        public List<MatchEventDto> Events { set; get; }
    }
}
