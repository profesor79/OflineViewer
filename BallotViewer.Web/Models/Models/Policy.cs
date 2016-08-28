using System;

namespace BallotViewer.Web.Models.Models
{
    public struct Policy
    {
        public int PolicyID { get; set; }
        public string PolicyTag { get; set; }
        public int? CustomerID { get; set; }
        public string PolicyName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string PolicyTypeCode { get; set; }
        public int? PolicyOwnerUserId { get; set; }
        public string DefaultDirectiveCode_ { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public bool IsGlobal { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public DateTime? LastGeneratedTmstp { get; set; }
        public DateTime? LastCriticalChangeTmstp { get; set; }
        public int MajorVersion { get; set; }
        public bool IsConservative { get; set; }
        public bool IsTNAInstructable { get; set; }
        public bool IsZeroSharesInstructable { get; set; }
        public string SWOPDefaultDirectiveCode { get; set; }
    }
}