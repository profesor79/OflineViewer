using System;

namespace ModelConverter.Models
{
    public class ProposalRecommendations
    {
        public int ProposalRecommendationId { get; set; }
        public int PolicyId { get; set; }
        public int AgendaItemId { get; set; }
        public string RecommendedVoteCode { get; set; }
        public string RecommendedByCode { get; set; }
        public string RecommendationText { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsRecoChanged { get; set; }
        public bool IsLocked { get; set; }
        public bool MgmtRecHasChanged { get; set; }
        public string NewMgmtRecVoteCode { get; set; }
        public bool PromoteNewMgmtRecVoteCode { get; set; }
        public DateTime NewMgmtRecChangedDate { get; set; }
    }
}