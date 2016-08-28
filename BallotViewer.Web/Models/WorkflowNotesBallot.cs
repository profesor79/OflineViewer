using System;

namespace BallotViewer.Web.Models
{
    public class WorkflowNotesBallot
    {
        public int BallotId { get; set; }
        public string Note { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}