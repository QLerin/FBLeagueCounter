using System.Collections.Generic;

namespace FBLeagueTimer.Entities
{
    public class MatchTimelineDto
    {
        public List<MatchFrameDto> Frames { set; get; }
        public long FramesInterval { set; get; }
    }
}
