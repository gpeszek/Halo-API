using System;

namespace HaloEzAPI.Model.Response
{
    public class CampaignMissionStat
    {
        public FlexibleStats FlexibleStats { get; set; }
        public CampaignRunThroughStats CoopStats { get; set; }
        public CampaignRunThroughStats SoloStats { get; set; }
        public Guid MissionId { get; set; }
    }
}