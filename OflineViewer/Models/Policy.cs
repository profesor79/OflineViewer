using System;
using System.Collections.Generic;

namespace OflineViewer.Models
{
    public struct Policy
    {


        public int PolicyID { get; set; }
        public string PolicyTag { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public string PolicyName { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string PolicyTypeCode { get; set; }
        public Nullable<int> PolicyOwnerUserId { get; set; }
        public string DefaultDirectiveCode_ { get; set; }
        public string Note { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public bool IsGlobal { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public Nullable<System.DateTime> LastGeneratedTmstp { get; set; }
        public Nullable<System.DateTime> LastCriticalChangeTmstp { get; set; }
        public int MajorVersion { get; set; }
        public bool IsConservative { get; set; }
        public bool IsTNAInstructable { get; set; }
        public bool IsZeroSharesInstructable { get; set; }
        public string SWOPDefaultDirectiveCode { get; set; }

        
        
        
        
    }
}
