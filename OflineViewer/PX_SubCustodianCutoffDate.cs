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
    
    public partial class PX_SubCustodianCutoffDate
    {
        public long SubCustodianCutoffDateID { get; set; }
        public Nullable<int> BatchID { get; set; }
        public string JobNumber { get; set; }
        public string CINS { get; set; }
        public string CustodianBank { get; set; }
        public string SettlementLocation { get; set; }
        public Nullable<System.DateTime> CutOffDate { get; set; }
        public Nullable<bool> IsObsolete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
    }
}