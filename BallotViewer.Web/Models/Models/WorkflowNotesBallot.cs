using System;

namespace BallotViewer.Web.Models.Models
{
    public struct WorkflowNotesBallot
    {
        public int BallotId { get; set; }
        public string Note { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}