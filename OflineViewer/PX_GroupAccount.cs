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
    
    public partial class PX_GroupAccount
    {
        public int GroupAccountID { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<int> AccountID { get; set; }
    
        public virtual AM_Account AM_Account { get; set; }
        public virtual AM_AccountGroup AM_AccountGroup { get; set; }
    }
}
