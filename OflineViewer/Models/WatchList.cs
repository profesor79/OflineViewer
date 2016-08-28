using System;

namespace OflineViewer.Models
{
    public struct WatchList
    {
        public int WatchListId { get; set; }
        public int CustomerId { get; set; }
        public string WatchListName { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public byte[] ConcurrencyTmstp { get; set; }
        public int ForAllAccounts { get; set; }
    }
}