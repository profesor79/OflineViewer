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
    
    public partial class PX_WatchListAccounts
    {
        public int WatchListAccountsID { get; set; }
        public int WatchListID { get; set; }
        public int AccountID { get; set; }
    
        public virtual AM_Account AM_Account { get; set; }
        public virtual PX_WatchList PX_WatchList { get; set; }
    }
}
