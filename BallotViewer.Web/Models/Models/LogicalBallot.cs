using System;

namespace BallotViewer.Web.Models.Models
{
    public class LogicalBallot
    {
        public int LogicalBallotId { get; set; }
        public int AgendaId { get; set; }
        public int GroupId { get; set; }
        public int PolicyId { get; set; }
        public string LogicalBallotComments { get; set; }
        public int BallotId { get; set; }
        public int SumNoOfBallots { get; set; }
        public double SumNoOfShares { get; set; }
        public string SumVoteStatusCode { get; set; }
        public string SumBallotStatusCode { get; set; }
        public string SumWatchList { get; set; }
        public DateTime MinVoteDeadlineDate { get; set; }
        public string FirstClassOfStockCode { get; set; }
        public DateTime LastCreatedDate { get; set; }
        public int LastApprovedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime InstructedDate { get; set; }
        public int InstructedBy { get; set; }
    }
}