using System;

namespace ModelConverter.Models
{
    public class AgendaItemLocal
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
    }
}