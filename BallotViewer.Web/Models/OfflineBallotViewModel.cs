using System.Collections.Generic;
namespace BallotViewer.Web.Models
{
    public class OfflineBallotViewModel
    {
        public OfflineBallotViewModel(IEnumerable<BallotAggregated> ballotsAggregated)
        {
            BallotsAggregated = ballotsAggregated;
        }

        public IEnumerable<BallotAggregated> BallotsAggregated { get; set; }
    }
}