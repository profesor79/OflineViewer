//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OflineViewer
{
    using System;
    using System.Collections.Generic;
    
    public partial class AM_Account
    {
        public AM_Account()
        {
            this.AM_SubAccount = new HashSet<AM_SubAccount>();
            this.PX_Ballot = new HashSet<PX_Ballot>();
            this.PX_GroupAccount = new HashSet<PX_GroupAccount>();
            this.PX_WatchListAccounts = new HashSet<PX_WatchListAccounts>();
        }
        public int CustomerID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountName { get; set; }
        public string ClientName { get; set; }
        public Nullable<int> VotingGroupId { get; set; }
        public Nullable<int> ReportingGroupId { get; set; }
        public System.DateTime AccountCreationDate { get; set; }
        public Nullable<int> PolicyID { get; set; }
        public string AccountStatusCode { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public string AccountSubStatusCode { get; set; }
        public string AccountTypeCode { get; set; }
        public string AccountVotingTypeCode { get; set; }
        public string BallotTypeCode { get; set; }
        public Nullable<bool> IsNonVotingAccount { get; set; }
        public Nullable<int> UploadBatchId { get; set; }
        public Nullable<bool> IsHoldingSentFlag { get; set; }
        public string HoldingsID { get; set; }
        public string HoldingsSourceCode { get; set; }
        public bool IsSelectedForDisclosure { get; set; }
        public string AccountReconcileTypeCode { get; set; }
        public Nullable<System.DateTime> ADPConfirmationDate { get; set; }
        public string AccountNotes { get; set; }
        public Nullable<bool> IsSelectedForNPX { get; set; }
        public Nullable<bool> IsHoldingReceived { get; set; }
        public Nullable<System.DateTime> HoldingsReceivedDate { get; set; }
        public Nullable<bool> IsDummy { get; set; }
        public Nullable<int> IsDummyOfAcctID { get; set; }
        public Nullable<System.DateTime> LastHoldingsProcessedDate { get; set; }
        public Nullable<int> BallotInboxGroupID { get; set; }
        public Nullable<decimal> PartialVotePercentage { get; set; }
        public Nullable<System.DateTime> AccountClosedDate { get; set; }
        public string ReportingRequirement { get; set; }
    
        public virtual AA_Customer AA_Customer { get; set; }
        public virtual ICollection<AM_SubAccount> AM_SubAccount { get; set; }
        public virtual ICollection<PX_Ballot> PX_Ballot { get; set; }
        public virtual ICollection<PX_GroupAccount> PX_GroupAccount { get; set; }
        public virtual ICollection<PX_WatchListAccounts> PX_WatchListAccounts { get; set; }
    }
}