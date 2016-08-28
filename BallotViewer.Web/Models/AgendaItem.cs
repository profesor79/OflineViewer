using System;
using System.Collections.Generic;

namespace BallotViewer.Web.Models
{
    public class AgendaItem
    {
        public int AgendaItemId { get; set; }
        public int AgendaId { get; set; }
        public string IssueCode { get; set; }
        public string ProposalNumber { get; set; }
        public string ProposalLabel { get; set; }
        public string ProposalTypeCode { get; set; }
        public string ProposalVoteOptionCode { get; set; }
        public string ProposalText { get; set; }
        public int NumberOfDirectors { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool IsManuallyEntered { get; set; }
        public string ProposalLongText { get; set; }
        public string RpProposalId { get; set; }
        public string NewProposalLongText { get; set; }
        public bool ProposalTextHasChanged { get; set; }
        public bool PromoteNewProposalText { get; set; }
        public DateTime ProposalTextChangedDate { get; set; }
        public bool IsCumulativeVoting { get; set; }
        public int CumulativeVotingMultiplier { get; set; }
        // public virtual AA_IssueCode AA_IssueCode { get; set; }
        public ICollection<AgendaSubItem> PxAgendaSubItem { get; set; }
        public ICollection<ProposalRecommendations> PxProposalRecommendations { get; set; }
    }
}