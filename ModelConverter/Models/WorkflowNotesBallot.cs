using System;

namespace ModelConverter.Models
{
    public class WorkflowNotesBallot
    {
        public int BallotId { get; set; }
        public string Note { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}