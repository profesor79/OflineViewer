using System;
using System.Collections.Generic;

namespace ModelConverter.Models
{
    public class Customer
    {
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
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public string PeriodicityCode { get; set; }
        public int? DaySelected { get; set; }
        public string ADPCustomerID { get; set; }
        public string CRMUserName { get; set; }
        public int? CRMCustomerId { get; set; }
        public string AutoInstructOptionCode { get; set; }
        public bool? IsShareBlockingTNAHold { get; set; }
        public bool? IsHoldingsLiquidatedTNA { get; set; }
        public string GLPCustomerID { get; set; }
        public string ContactName { get; set; }
        public int? GLContactUserID { get; set; }
        public bool? SendRecommendation { get; set; }
        public int PasswordExpiryPeriod { get; set; }
        public decimal? PercentageOutstandingShares { get; set; }
        public string ExtractFileCopyAddress { get; set; }
        public bool UsePredefinedProformas { get; set; }
        public bool ValidateVoteNoteIfVoteAgainstMgmt { get; set; }
        public decimal? PartialVotePercentage { get; set; }
        public int PasswordAuthenticationLevel { get; set; }
        public bool? BallotsTradedToZero { get; set; }
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


        public ICollection<Policy> PL_Policy { get; set; }
        //public  ICollection<PX_VoteExecutionProfile> PX_VoteExecutionProfile { get; set; }
        //public  ICollection<PX_VotingInstructions> PX_VotingInstructions { get; set; }
    }
}