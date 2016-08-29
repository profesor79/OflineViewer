using System;

namespace ModelConverter.Models
{
    public class Shares
    {
        public int BallotId { get; set; }
        public int CustomerId { get; set; }
        public int AgendaId { get; set; }
        public int MeetingId { get; set; }
        public int PolicyId { get; set; }
        public int AccountId { get; set; }
        public decimal BallotSharesOnLoan { get; set; }
        public decimal HoldingsSharesHeld { get; set; }
        public decimal HoldingsSharesOnLoan { get; set; }
        public int SecuritySymbolId { get; set; }
        public int MeetingSecuritySymbolId { get; set; }
        public long LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }


}