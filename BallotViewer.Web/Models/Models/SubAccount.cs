namespace BallotViewer.Web.Models.Models
{
    public class SubAccount
    {
        public int SubAccountId { get; set; }
        public int AccountId { get; set; }
        public string SubAccountName { get; set; }
        public string SubAccountStatusCode { get; set; }
    }
}