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
    
    public partial class PX_WorkflowNotes_AgendaPolicy
    {
        public int AgendaID { get; set; }
        public int PolicyID { get; set; }
        public string Note { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
    
        public virtual PL_Policy PL_Policy { get; set; }
        public virtual PX_Agenda PX_Agenda { get; set; }
    }
}
