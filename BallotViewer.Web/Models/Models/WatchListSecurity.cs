namespace BallotViewer.Web.Models.Models
{
    public struct WatchListSecurity
    {
        public int SecurityId { get; set; }
        public int WatchListId { get; set; }
        public int PxWatchListSecurityId { get; set; }
        public WatchList PxWatchList { get; set; }
    }
}