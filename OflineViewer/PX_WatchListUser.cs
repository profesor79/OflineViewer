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
    
    public partial class PX_WatchListUser
    {
        public int WatchListUsersID { get; set; }
        public int WatchListID { get; set; }
        public int UserID { get; set; }
        public bool IsOwner { get; set; }
    
        public virtual PX_WatchList PX_WatchList { get; set; }
    }
}
