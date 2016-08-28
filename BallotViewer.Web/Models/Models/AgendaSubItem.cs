using System;
using System.Collections.Generic;

namespace BallotViewer.Web.Models.Models
{
    public class AgendaSubItem
    {
        public int AgendaSubItemId { get; set; }
        public string AgendaSubItemText { get; set; }
        public string AgendaSubItemNumber { get; set; }
        public int AgendaItemId { get; set; }
        public int BatchControlId { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public bool IsManuallyEntered { get; set; }
        public string AgendaSubItemLongText { get; set; }
        public string NewSubProposalLongText { get; set; }
        public bool SubProposalTextHasChanged { get; set; }
        public bool PromoteNewSubProposalText { get; set; }
        public DateTime SubProposalTextChangedDate { get; set; }
        public ICollection<AgendaSubItemRecommendations> PxAgendaSubItemRecommendations { get; set; }
    }
}