using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BallotViewer.Web.Models
{
    [DataContract]
    public class OfflineBallotViewModel
    {
        public OfflineBallotViewModel(IEnumerable<BallotAggregated> ballotsAggregated)
        {
            BallotsAggregated = ballotsAggregated;
        }

        public IEnumerable<BallotAggregated> BallotsAggregated { get; set; }
        public BallotAggregated BallotAggregated { get; set; }
    }
}