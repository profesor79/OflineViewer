namespace BallotViewer.Web.Models
{
    public class WatchListSecurity
    {
        public int SecurityId { get; set; }
        public int WatchListId { get; set; }
        public int PxWatchListSecurityId { get; set; }
        public WatchList PxWatchList { get; set; }
    }
}