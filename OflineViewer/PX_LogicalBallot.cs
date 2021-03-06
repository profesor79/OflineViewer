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
    
    public partial class PX_LogicalBallot
    {
        public PX_LogicalBallot()
        {
            this.PX_Ballot = new HashSet<PX_Ballot>();
        }
    
        public int LogicalBallotID { get; set; }
        public Nullable<int> AgendaID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<int> PolicyID { get; set; }
        public string LogicalBallotComments { get; set; }
        public Nullable<int> BallotID { get; set; }
        public Nullable<int> SumNoOfBallots { get; set; }
        public Nullable<double> SumNoOfShares { get; set; }
        public string SumVoteStatusCode { get; set; }
        public string SumBallotStatusCode { get; set; }
        public string SumWatchList { get; set; }
        public Nullable<System.DateTime> MinVoteDeadlineDate { get; set; }
        public string FirstClassOfStockCode { get; set; }
        public Nullable<System.DateTime> LastCreatedDate { get; set; }
        public Nullable<int> LastApprovedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> InstructedDate { get; set; }
        public Nullable<int> InstructedBy { get; set; }
    
        public virtual ICollection<PX_Ballot> PX_Ballot { get; set; }
    }
}
