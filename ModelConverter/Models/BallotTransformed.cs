using System.Collections.Generic;
using OflineViewer.Models;

namespace ModelConverter.Models
{
    public class BallotTransformed
    {
        //these need to be ignored in base mapping
        public BallotLocal Ballot { get; set; }

        // from ballot2
        public WorkflowNotesBallot PxWorkflowNotesBallot { get; set; }
        public ICollection<BallotAuditTrail> PxBallotAuditTrail { get; set; }
        public ICollection<BallotVotesLocal> PxBallotVotes { get; set; }
        // from ballotVotes
        public ICollection<BallotSubItemVotes> PxBallotSubItemVotes { get; set; }

        public ICollection<Shares> PxShares { get; set; }

        public AccountLocal AmAccount { get; set; }
        //from account
        public Customer AA_Customer { get; set; }

        public LogicalBallot PxLogicalBallot { get; set; }
        //end from ballot 2


        public MeetingLocal Meeting { get; set; }
        //from meetingAggregated
        public Security AaSecurity { get; set; }
        //end from meetingAggregated

        public AgendaLocal Agenda { get; set; }
        //from AgendgaAggregated
        public ICollection<AgendaItemLocal> PxAgendaItem { get; set; }

        //from agendaItem
        public ICollection<AgendaSubItemLocal> PxAgendaSubItem { get; set; }
        //from agendasubitem
        public ICollection<AgendaSubItemRecommendations> PxAgendaSubItemRecommendations { get; set; }
        public ICollection<ProposalRecommendations> PxProposalRecommendations { get; set; }

        //end from AgendgaujciAggregated
    }
}