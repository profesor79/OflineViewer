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
    
    public partial class AA_Customer
    {
        public AA_Customer()
        {
            this.AM_Account = new HashSet<AM_Account>();
            this.PL_Policy = new HashSet<PL_Policy>();
            this.PX_VoteExecutionProfile = new HashSet<PX_VoteExecutionProfile>();
            this.PX_VotingInstructions = new HashSet<PX_VotingInstructions>();
        }
    
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string WorkPhone { get; set; }
        public string FaxNumber { get; set; }
        public string StatusCode { get; set; }
        public string CustomerCategory { get; set; }
        public string CustomerType { get; set; }
        public string DefaultDirectiveCode { get; set; }
        public string ModeOfFileReceipt { get; set; }
        public string FileReceiptAddress { get; set; }
        public bool DeletedFlag { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public string PeriodicityCode { get; set; }
        public Nullable<int> DaySelected { get; set; }
        public string ADPCustomerID { get; set; }
        public string CRMUserName { get; set; }
        public Nullable<int> CRMCustomerId { get; set; }
        public string AutoInstructOptionCode { get; set; }
        public Nullable<bool> IsShareBlockingTNAHold { get; set; }
        public Nullable<bool> IsHoldingsLiquidatedTNA { get; set; }
        public string GLPCustomerID { get; set; }
        public string ContactName { get; set; }
        public Nullable<int> GLContactUserID { get; set; }
        public Nullable<bool> SendRecommendation { get; set; }
        public int PasswordExpiryPeriod { get; set; }
        public Nullable<decimal> PercentageOutstandingShares { get; set; }
        public string ExtractFileCopyAddress { get; set; }
        public bool UsePredefinedProformas { get; set; }
        public bool ValidateVoteNoteIfVoteAgainstMgmt { get; set; }
        public Nullable<decimal> PartialVotePercentage { get; set; }
        public int PasswordAuthenticationLevel { get; set; }
        public Nullable<bool> BallotsTradedToZero { get; set; }
        public int NumofPasswordstoBeStored { get; set; }
        public bool CanAlwaysResetPassword { get; set; }
        public bool PasswordNeverExpires { get; set; }
        public bool EnableSecurityQuestions { get; set; }
        public int NumberofQuestions { get; set; }
        public int NumberofRequiredAnswers { get; set; }
        public int MinimumPasswordAge { get; set; }
        public bool ShareMeetingTokensAllowed { get; set; }
        public bool VotingMultiplePoliciesWarning { get; set; }
        public bool VotingAgainstPolicyWarning { get; set; }
    
        public virtual ICollection<AM_Account> AM_Account { get; set; }
        public virtual ICollection<PL_Policy> PL_Policy { get; set; }
        public virtual ICollection<PX_VoteExecutionProfile> PX_VoteExecutionProfile { get; set; }
        public virtual ICollection<PX_VotingInstructions> PX_VotingInstructions { get; set; }
    }
}
