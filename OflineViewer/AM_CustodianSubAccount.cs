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
    
    public partial class AM_CustodianSubAccount
    {
        public int CustodianSubAccountID { get; set; }
        public int AccountID { get; set; }
        public int CustodianID { get; set; }
        public string CustodianSubAccountNumber { get; set; }
        public string CustodianSubAccountName { get; set; }
        public string AltDeliveryModeCode { get; set; }
        public Nullable<System.DateTime> CustodianConfirmationDate { get; set; }
        public string GlobalBallotOriginCode { get; set; }
        public string DomesticBallotOriginCode { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public string AccountEquityProfile { get; set; }
        public string BallotReconciliationRequired { get; set; }
        public Nullable<System.DateTime> CustodianSubAccountOpenDate { get; set; }
        public Nullable<System.DateTime> CustodianSubAccountCloseDate { get; set; }
        public string ManualBallotCreationRequired { get; set; }
        public string POAStatus { get; set; }
    }
}
