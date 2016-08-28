using System;

namespace BallotViewer.Web.Models.Models
{
    public struct AgendaSubItemRecommendations
    {
        public int AgendaSubItemRecommendationId { get; set; }
        public int AgendaSubItemId { get; set; }
        public int PolicyId { get; set; }
        public string RecommendedVoteCode { get; set; }
        public string RecommendedByCode { get; set; }
        public string RecommendationText { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool IsRecoChanged { get; set; }
        public bool IsLocked { get; set; }
    }
}