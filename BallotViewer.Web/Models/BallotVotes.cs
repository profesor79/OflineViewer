using System;
using System.Collections.Generic;

namespace BallotViewer.Web.Models
{
    public class BallotVotes
    {
        public int BallotVoteId { get; set; }
        public int BallotId { get; set; }
        public int AgendaItemId { get; set; }
        public string ActualVoteCode { get; set; }
        public string VotingInstructions { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public bool VoteAgainstPolicy { get; set; }
        public ICollection<BallotSubItemVotes> PxBallotSubItemVotes { get; set; }
    }
}