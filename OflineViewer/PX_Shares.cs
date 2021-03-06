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
    
    public partial class PX_Shares
    {
        public int BallotID { get; set; }
        public int CustomerID { get; set; }
        public int AgendaID { get; set; }
        public int MeetingID { get; set; }
        public int PolicyID { get; set; }
        public int AccountID { get; set; }
        public Nullable<decimal> BallotSharesOnLoan { get; set; }
        public Nullable<decimal> HoldingsSharesHeld { get; set; }
        public Nullable<decimal> HoldingsSharesOnLoan { get; set; }
        public Nullable<int> SecuritySymbolId { get; set; }
        public Nullable<int> MeetingSecuritySymbolId { get; set; }
        public Nullable<long> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    
        public virtual PX_Ballot PX_Ballot { get; set; }
    }
}
