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
    
    public partial class PX_VotingInstructions
    {
        public int VotingInstructionID { get; set; }
        public int CustomerId { get; set; }
        public string VotingInstruction { get; set; }
        public bool IsSubItemInstruction { get; set; }
    
        public virtual AA_Customer AA_Customer { get; set; }
    }
}
