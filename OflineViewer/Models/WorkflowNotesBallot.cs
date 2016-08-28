using System;

namespace OflineViewer.Models
{
    public struct WorkflowNotesBallot
    {
        public int BallotId { get; set; }
        public string Note { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}