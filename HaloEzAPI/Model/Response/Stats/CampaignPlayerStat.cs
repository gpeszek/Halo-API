namespace HaloEzAPI.Model.Response.Stats
{
    public class CampaignPlayerStat : PlayerMatchBreakdown
    {
        public uint BiggestKillScore { get; set; }
        public FlexibleStats FlexibleStats { get; set; }
        public uint Score { get; set; }
        public Player Player { get; set; }
        public int TeamId { get; set; }
        public int Rank { get; set; }
        public bool DNF { get; set; }
        public string AvgLifeTimeOfPlayer { get; set; }
    }
}