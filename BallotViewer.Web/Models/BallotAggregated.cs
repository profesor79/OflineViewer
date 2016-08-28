using System.Runtime.Serialization;
using MongoDB.Bson;

namespace BallotViewer.Web.Models
{
    [DataContract]
    public class BallotAggregated
    {
        [DataMember]
        public ObjectId _id { get; set; }

        //these need to be ignored in base mapping
        [DataMember]
        public Ballot2 Ballot { get; set; }

        [DataMember]
        public MeetingAggregated MeetingAggregated { get; set; }

        [DataMember]
        public AgendaAggregated AgendaAggregated { get; set; }
    }
}