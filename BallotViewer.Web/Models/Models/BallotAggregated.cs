using MongoDB.Bson;

namespace BallotViewer.Web.Models.Models
{
    public class BallotAggregated
    {
        public ObjectId _id { get; set; }
        //these need to be ignored in base mapping
        public Ballot2 Ballot { get; set; }
        public MeetingAggregated MeetingAggregated { get; set; }
        public AgendaAggregated AgendaAggregated { get; set; }
    }
}