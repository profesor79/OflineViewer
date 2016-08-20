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
    
    public partial class AA_SecuritySymbol
    {
        public int SecuritySymbolID { get; set; }
        public int SecurityID { get; set; }
        public string SymbolTypeCode { get; set; }
        public string SymbolNumber { get; set; }
        public string SecurityClassCode { get; set; }
        public string CountryCode { get; set; }
        public string Ticker { get; set; }
        public Nullable<bool> IsPrimary { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool DeletedFlag { get; set; }
        public string Exchange { get; set; }
        public string Register { get; set; }
        public string Market { get; set; }
        public string Currency { get; set; }
        public Nullable<System.DateTime> ValidFromDate { get; set; }
        public Nullable<System.DateTime> ValidToDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> EDI_IssID { get; set; }
        public Nullable<long> EDI_SecID { get; set; }
        public Nullable<long> EDI_SedolID { get; set; }
        public string SecurityDescription { get; set; }
        public Nullable<long> SharesOutstanding { get; set; }
        public Nullable<bool> SecuritySymbolMerged { get; set; }
        public Nullable<int> MergedSymbolID { get; set; }
    
        public virtual AA_Security AA_Security { get; set; }
    }
}
