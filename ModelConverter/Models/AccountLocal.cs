using System;
using System.Collections.Generic;

namespace ModelConverter.Models
{
    public class AccountLocal
    {
        public int CustomerId { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountName { get; set; }
        public string ClientName { get; set; }
        public int VotingGroupId { get; set; }
        public int ReportingGroupId { get; set; }
        public DateTime AccountCreationDate { get; set; }
        public int PolicyId { get; set; }
        public string AccountStatusCode { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public string AccountSubStatusCode { get; set; }
        public string AccountTypeCode { get; set; }
        public string AccountVotingTypeCode { get; set; }
        public string BallotTypeCode { get; set; }
        public bool IsNonVotingAccount { get; set; }
        public int UploadBatchId { get; set; }
        public bool IsHoldingSentFlag { get; set; }
        public string HoldingsId { get; set; }
        public string HoldingsSourceCode { get; set; }
        public bool IsSelectedForDisclosure { get; set; }
        public string AccountReconcileTypeCode { get; set; }
        public DateTime AdpConfirmationDate { get; set; }
        public string AccountNotes { get; set; }
        public bool IsSelectedForNpx { get; set; }
        public bool IsHoldingReceived { get; set; }
        public DateTime HoldingsReceivedDate { get; set; }
        public bool IsDummy { get; set; }
        public int IsDummyOfAcctId { get; set; }
        public DateTime LastHoldingsProcessedDate { get; set; }
        public int BallotInboxGroupId { get; set; }
        public decimal PartialVotePercentage { get; set; }
        public DateTime AccountClosedDate { get; set; }
        public string ReportingRequirement { get; set; }


        public ICollection<SubAccount> AM_SubAccount { get; set; }
    }
}