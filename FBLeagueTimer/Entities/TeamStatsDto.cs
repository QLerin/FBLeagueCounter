using System.Collections.Generic;

namespace FBLeagueTimer.Entities
{
    public class TeamStatsDto
    {
        public bool FirstDragon { set; get; }
        public bool FirstInhibitor { set; get; }
        public List<TeamBansDto> Bans { set; get; }
        public int BaronKills { set; get; }
        public bool FirstRiftHerald { set; get; }
        public bool FirstBaron { set; get; }
        public int RiftHeraldKills { set; get; }
        public bool FirstBlood { set; get; }
        public int TeamId { set; get; }
        public bool FirstTower { set; get; }
        public int VilemawKills { set; get; }
        public int InhibitorKills { set; get; }
        public int TowerKills { set; get; }
        public int DominionVictoryScore { set; get; }
        public string Win { set; get; }
        public int DragonKills { set; get; }
    }
}
