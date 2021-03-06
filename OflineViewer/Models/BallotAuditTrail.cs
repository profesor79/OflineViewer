﻿using System;

namespace OflineViewer.Models
{
    public struct BallotAuditTrail
    {
        public int BallotAuditTrailId { get; set; }
        public int BallotId { get; set; }
        public string ControlNumberKey { get; set; }
        public string BallotStatusCode { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public string VoteStatusCode { get; set; }
        public bool IsCopiedForReporting { get; set; }
        public decimal NoOfShares { get; set; }
        public decimal BallotSharesOnLoan { get; set; }
        public string ProposalVotes { get; set; }
        public string DirectorVotes { get; set; }
        public DateTime InstructedDate { get; set; }
        public int LogicalBallotId { get; set; }
        public bool NonStandardVote { get; set; }
        public int InstructedBy { get; set; }
    }
}