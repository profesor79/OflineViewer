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
    
    public partial class PX_VoteExecutionVotingMarketException
    {
        public int VotingMarketExpectionID { get; set; }
        public int VoteExecutionProfileID { get; set; }
        public string CountryCode { get; set; }
        public int ExceptionCode { get; set; }
    
        public virtual PX_VoteExecutionProfile PX_VoteExecutionProfile { get; set; }
    }
}