namespace OflineViewer.Models
{
    public struct BallotAggregated
    {
        //these need to be ignored in base mapping
        public Ballot2 Ballot { get; set; }
        public MeetingAggregated MeetingAggregated { get; set; }
        public AgendaAggregated AgendaAggregated { get; set; }
    }
}