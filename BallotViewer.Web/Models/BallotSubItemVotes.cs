﻿using System;

namespace BallotViewer.Web.Models
{
    public class BallotSubItemVotes
    {
        public int BallotSubItemVoteId { get; set; }
        public int AgendaSubItemId { get; set; }
        public int BallotVoteId { get; set; }
        public string ActualVoteCode { get; set; }
        public string VotingInclassions { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool VoteAgainstPolicy { get; set; }
    }
}